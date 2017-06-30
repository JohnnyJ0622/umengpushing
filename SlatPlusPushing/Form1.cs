using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlatPlusPushing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getPostBody(string deviceType)
        {
            var paramAndroid = new
            {
                appkey = "xxxxxxxxxxxxxxxxxxxxxxx",
                timestamp = ConvertDateTimeToInt(DateTime.Now.AddHours(1)).ToString().Substring(0, 10),
                production_mode = "true",
                description = "文章推送ID: " + articleIDTextBox.Text,
                type = "broadcast",
                payload = new
                {
                    extra = new
                    {
                        type = "article",
                        id = articleIDTextBox.Text,
                    },
                    body = new
                    {
                        title = articleTitleTextBox.Text,
                        ticker = articleTitleTextBox.Text,
                        text = articleContentRichTextBox.Text,
                        after_open = "go_app",
                        play_vibrate = "true",
                        play_sound = "true",
                        play_lights = "true"
                    },
                    display_type = "notification"
                }
            };

            var paramIOS = new
            {
                appkey = "xxxxxxxxxxxxxxxxxxxxxxx",
                timestamp = ConvertDateTimeToInt(DateTime.Now.AddHours(1)).ToString().Substring(0, 10),
                production_mode = "true",
                description = "走进新西兰",
                type = "broadcast",
                payload = new
                {
                    aps = new
                    {
                        sound = "default",
                        badge = 1,
                        alert = new
                        {
                            body = articleContentRichTextBox.Text,
                            title = articleTitleTextBox.Text
                        },
                    },
                    articleId = articleIDTextBox.Text,
                    category = "新西兰",
                    policy = new
                    {
                        expire_time = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd HH:mm:ss")
                    }
                }
            };

            var serializer = JsonSerializer.Create();
            var jsonWriter = new System.IO.StringWriter();
            if ("Andriod".Equals(deviceType))
            {
                serializer.Serialize(jsonWriter, paramAndroid);
            }
            else
            {
                serializer.Serialize(jsonWriter, paramIOS);
            }
            var post_body = jsonWriter.ToString();
            post_body = unicode_js_0(post_body);//.Replace(":", ": ").Replace(",", ", ");
            var str = post_body;
            return str;
        }

        private string GetSign(string deviceType)
        {
            var app_master_secret = "xxxxxxxxxxxxxxxxxxxxxxx";
            if ("Andriod".Equals(deviceType))
            {
                app_master_secret = "xxxxxxxxxxxxxxxxxxxxxxx";
            }

            if ("iOS".Equals(deviceType))
            {
                app_master_secret = "xxxxxxxxxxxxxxxxxxxxxxx";
            }

            var method = "POST";
            var url = "http://msg.umeng.com/api/send";
            string postBody = this.getPostBody(deviceType);
            var str = method + url + postBody + app_master_secret;
            var sign = MD5(str);
            return sign;
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string MD5(string s)
        {

            var x = new MD5CryptoServiceProvider();
            var bs = System.Text.Encoding.UTF8.GetBytes(s);
            bs = x.ComputeHash(bs);
            var str = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                str.Append(b.ToString("x2").ToLower());
            }
            return str.ToString();
        }
        /// <summary>
        /// 中文转unicode（符合js规则的）
        /// </summary>
        /// <returns></returns>
        public string unicode_js_0(string str)
        {
            var outStr = string.Empty;
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (Regex.IsMatch(str[i].ToString(), @"[\u4e00-\u9fa5]")) { outStr += "\\u" + ((int)str[i]).ToString("x"); }
                    else { outStr += str[i]; }
                }
            }
            return outStr;
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            pushButton.Enabled = false;

            string message = "";
            if ("".Equals(articleIDTextBox.Text))
            {
                MessageBox.Show("The article ID cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                articleIDTextBox.Focus();

            }
            else if ("".Equals(articleTitleTextBox.Text))
            {
                MessageBox.Show("The article title cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                articleTitleTextBox.Focus();
            }
            else if ("".Equals(articleContentRichTextBox.Text))
            {
                MessageBox.Show("The article content cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                articleContentRichTextBox.Focus();
            }
            else
            {
                if (iOSCheckBox.Checked)
                {
                    message = message + this.callUMengAPI("iOS");
                }
                if (AndroidCheckBox.Checked)
                {
                    message = message + this.callUMengAPI("Andriod");
                }
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pushButton.Enabled = true;
        }

        private string callUMengAPI(string device)
        {
            string message = device;
            string sign = this.GetSign(device);
            string url = "http://msg.umeng.com/api/send?sign=" + sign;

            Console.WriteLine(url);

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/json";
            string data = getPostBody(device);

            Console.WriteLine(data);

            byte[] byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());
            request.ContentLength = byteData.Length;
            try
            {
                using (Stream postStream = request.GetRequestStream())
                {
                    postStream.Write(byteData, 0, byteData.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    Console.WriteLine(reader.ReadToEnd());
                }
                message = message + " pushing succeed! ";
                return message;
            }
            catch (Exception ex)
            {
                message = message + " pushing FAIL! ";
                return message;
            }
        }

        private long ConvertDateTimeToInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = (time.Ticks - startTime.Ticks) / 10000;   //除10000调整为13位      
            return t;
        }

        private void buttonPull_Click(object sender, EventArgs e)
        {
            buttonPull.Enabled = false;
            pushButton.Enabled = false;

            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            Byte[] pageData = wc.DownloadData("https://app.nzinfo.cn/index.php/h5/article/detail?id=" + articleIDTextBox.Text);
            String webString = Encoding.UTF8.GetString(pageData);
            Console.WriteLine(webString);

            Match TitleMatch = Regex.Match(webString, "<title>([^<]*)</title>", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            articleTitleTextBox.Text = TitleMatch.Groups[1].Value;
            
            buttonPull.Enabled = true;
            pushButton.Enabled = true;
        }
    }
}

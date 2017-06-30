namespace SlatPlusPushing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.articleIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.articleTitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.articleContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AndroidCheckBox = new System.Windows.Forms.CheckBox();
            this.iOSCheckBox = new System.Windows.Forms.CheckBox();
            this.pushButton = new System.Windows.Forms.Button();
            this.buttonPull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // articleIDTextBox
            // 
            this.articleIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleIDTextBox.Location = new System.Drawing.Point(209, 46);
            this.articleIDTextBox.Name = "articleIDTextBox";
            this.articleIDTextBox.Size = new System.Drawing.Size(327, 26);
            this.articleIDTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Article ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Article Title:";
            // 
            // articleTitleTextBox
            // 
            this.articleTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleTitleTextBox.Location = new System.Drawing.Point(209, 101);
            this.articleTitleTextBox.Name = "articleTitleTextBox";
            this.articleTitleTextBox.Size = new System.Drawing.Size(434, 26);
            this.articleTitleTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Article Content:";
            // 
            // articleContentRichTextBox
            // 
            this.articleContentRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleContentRichTextBox.Location = new System.Drawing.Point(209, 157);
            this.articleContentRichTextBox.Name = "articleContentRichTextBox";
            this.articleContentRichTextBox.Size = new System.Drawing.Size(434, 96);
            this.articleContentRichTextBox.TabIndex = 6;
            this.articleContentRichTextBox.Text = "";
            // 
            // AndroidCheckBox
            // 
            this.AndroidCheckBox.AutoSize = true;
            this.AndroidCheckBox.Checked = true;
            this.AndroidCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AndroidCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AndroidCheckBox.Location = new System.Drawing.Point(70, 306);
            this.AndroidCheckBox.Name = "AndroidCheckBox";
            this.AndroidCheckBox.Size = new System.Drawing.Size(83, 24);
            this.AndroidCheckBox.TabIndex = 7;
            this.AndroidCheckBox.Text = "Android";
            this.AndroidCheckBox.UseVisualStyleBackColor = true;
            // 
            // iOSCheckBox
            // 
            this.iOSCheckBox.AutoSize = true;
            this.iOSCheckBox.Checked = true;
            this.iOSCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iOSCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOSCheckBox.Location = new System.Drawing.Point(209, 306);
            this.iOSCheckBox.Name = "iOSCheckBox";
            this.iOSCheckBox.Size = new System.Drawing.Size(54, 24);
            this.iOSCheckBox.TabIndex = 8;
            this.iOSCheckBox.Text = "iOS";
            this.iOSCheckBox.UseVisualStyleBackColor = true;
            // 
            // pushButton
            // 
            this.pushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushButton.Location = new System.Drawing.Point(568, 298);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 32);
            this.pushButton.TabIndex = 9;
            this.pushButton.Text = "push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // buttonPull
            // 
            this.buttonPull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPull.Location = new System.Drawing.Point(568, 46);
            this.buttonPull.Name = "buttonPull";
            this.buttonPull.Size = new System.Drawing.Size(75, 26);
            this.buttonPull.TabIndex = 10;
            this.buttonPull.Text = "Pull";
            this.buttonPull.UseVisualStyleBackColor = true;
            this.buttonPull.Click += new System.EventHandler(this.buttonPull_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 385);
            this.Controls.Add(this.buttonPull);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.iOSCheckBox);
            this.Controls.Add(this.AndroidCheckBox);
            this.Controls.Add(this.articleContentRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.articleTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleIDTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SLATPLUS MESSAGE PUSHING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox articleIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox articleTitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox articleContentRichTextBox;
        private System.Windows.Forms.CheckBox AndroidCheckBox;
        private System.Windows.Forms.CheckBox iOSCheckBox;
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.Button buttonPull;
    }
}


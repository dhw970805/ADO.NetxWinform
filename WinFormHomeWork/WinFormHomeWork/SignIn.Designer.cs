namespace WinFormHomeWork
{
    partial class SignIn
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
            this.sure = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.passwod = new System.Windows.Forms.TextBox();
            this.surepassword = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(79, 239);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(117, 23);
            this.sure.TabIndex = 0;
            this.sure.Text = "确认";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(235, 239);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(124, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // passwod
            // 
            this.passwod.Location = new System.Drawing.Point(185, 85);
            this.passwod.Name = "passwod";
            this.passwod.PasswordChar = '*';
            this.passwod.Size = new System.Drawing.Size(174, 21);
            this.passwod.TabIndex = 2;
            // 
            // surepassword
            // 
            this.surepassword.Location = new System.Drawing.Point(185, 135);
            this.surepassword.Name = "surepassword";
            this.surepassword.Size = new System.Drawing.Size(174, 21);
            this.surepassword.TabIndex = 3;
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(185, 38);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(174, 21);
            this.userid.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(185, 184);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(174, 21);
            this.email.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(77, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(77, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "确认密码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(77, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "电子邮箱";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 287);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.surepassword);
            this.Controls.Add(this.passwod);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.sure);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sure;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox passwod;
        private System.Windows.Forms.TextBox surepassword;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
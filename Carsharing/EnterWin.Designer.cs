namespace Carsharing
{
    partial class EnterWin
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
            this.textBoxNumb = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.EnterInfo = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumb
            // 
            this.textBoxNumb.Location = new System.Drawing.Point(130, 59);
            this.textBoxNumb.Name = "textBoxNumb";
            this.textBoxNumb.Size = new System.Drawing.Size(157, 22);
            this.textBoxNumb.TabIndex = 0;
            this.textBoxNumb.Text = "+7";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(130, 97);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(157, 22);
            this.textBoxPass.TabIndex = 1;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(12, 62);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(116, 17);
            this.Number.TabIndex = 2;
            this.Number.Text = "Номер телефона";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(62, 100);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 17);
            this.Password.TabIndex = 3;
            this.Password.Text = "Пароль";
            // 
            // EnterInfo
            // 
            this.EnterInfo.AutoSize = true;
            this.EnterInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterInfo.Location = new System.Drawing.Point(25, 21);
            this.EnterInfo.Name = "EnterInfo";
            this.EnterInfo.Size = new System.Drawing.Size(262, 17);
            this.EnterInfo.TabIndex = 4;
            this.EnterInfo.Text = "Введите Ваш номер телефона и пароль";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Next.Location = new System.Drawing.Point(193, 138);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 5;
            this.Next.Text = "Войти";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // EnterWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 173);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.EnterInfo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxNumb);
            this.Name = "EnterWin";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumb;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label EnterInfo;
        private System.Windows.Forms.Button Next;
    }
}
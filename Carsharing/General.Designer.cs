﻿namespace Carsharing
{
    partial class General
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.Vhod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Rent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vhod
            // 
            this.Vhod.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Vhod.Location = new System.Drawing.Point(485, 12);
            this.Vhod.Name = "Vhod";
            this.Vhod.Size = new System.Drawing.Size(181, 64);
            this.Vhod.TabIndex = 0;
            this.Vhod.Text = "Войти";
            this.Vhod.UseVisualStyleBackColor = false;
            this.Vhod.Click += new System.EventHandler(this.Vhod_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(672, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Зарегистрироваться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(37, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "Каршеринг \"Драйв\"";
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Account.Location = new System.Drawing.Point(495, 20);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(152, 48);
            this.Account.TabIndex = 4;
            this.Account.Text = "Фамилия Имя";
            this.Account.UseVisualStyleBackColor = false;
            this.Account.Visible = false;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exit.Location = new System.Drawing.Point(673, 24);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(135, 41);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выход из аккаунта";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Rent
            // 
            this.Rent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rent.Location = new System.Drawing.Point(594, 82);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(152, 46);
            this.Rent.TabIndex = 6;
            this.Rent.Text = "Аренда";
            this.Rent.UseVisualStyleBackColor = false;
            this.Rent.Visible = false;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Vhod);
            this.Name = "General";
            this.Text = "Сервис \"Каршеринг\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Vhod;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Account;
        public System.Windows.Forms.Button Exit;
        public System.Windows.Forms.Button Rent;
        public System.Windows.Forms.Label label3;
    }
}


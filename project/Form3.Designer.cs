
namespace проект
{
    partial class User
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDob = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnTabl = new System.Windows.Forms.Button();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.btnOch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(402, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(235, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(305, 22);
            this.textBox5.TabIndex = 4;
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(12, 149);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResults.Size = new System.Drawing.Size(1014, 371);
            this.tbResults.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Аккаунт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Избранные маршруты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Избранные остановки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Данные банковской карты";
            // 
            // btnDob
            // 
            this.btnDob.Location = new System.Drawing.Point(750, 71);
            this.btnDob.Name = "btnDob";
            this.btnDob.Size = new System.Drawing.Size(130, 52);
            this.btnDob.TabIndex = 12;
            this.btnDob.Text = "Добавить";
            this.btnDob.UseVisualStyleBackColor = true;
            this.btnDob.Click += new System.EventHandler(this.btnDob_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(896, 74);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(130, 47);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Очистить таблицу";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnTabl
            // 
            this.btnTabl.Location = new System.Drawing.Point(896, 12);
            this.btnTabl.Name = "btnTabl";
            this.btnTabl.Size = new System.Drawing.Size(130, 50);
            this.btnTabl.TabIndex = 15;
            this.btnTabl.Text = "Показать таблицу";
            this.btnTabl.UseVisualStyleBackColor = true;
            this.btnTabl.Click += new System.EventHandler(this.btnTabl_Click);
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(750, 12);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(130, 50);
            this.btnPoisk.TabIndex = 16;
            this.btnPoisk.Text = "Найти по имени";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // btnOch
            // 
            this.btnOch.Location = new System.Drawing.Point(602, 38);
            this.btnOch.Name = "btnOch";
            this.btnOch.Size = new System.Drawing.Size(130, 53);
            this.btnOch.TabIndex = 17;
            this.btnOch.Text = "Очистить поля ввода";
            this.btnOch.UseVisualStyleBackColor = true;
            this.btnOch.Click += new System.EventHandler(this.btnOch_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 532);
            this.Controls.Add(this.btnOch);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.btnTabl);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "User";
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDob;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnTabl;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.Button btnOch;
    }
}
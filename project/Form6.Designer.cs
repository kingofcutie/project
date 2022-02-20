
namespace проект
{
    partial class RaspisDvizh
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnDob = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnTabl = new System.Windows.Forms.Button();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.btnOch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(545, 361);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Остановка";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Маршрут транспорта";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время прибытия";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 22);
            this.textBox4.TabIndex = 6;
            // 
            // btnDob
            // 
            this.btnDob.Location = new System.Drawing.Point(31, 167);
            this.btnDob.Name = "btnDob";
            this.btnDob.Size = new System.Drawing.Size(175, 75);
            this.btnDob.TabIndex = 7;
            this.btnDob.Text = "Добавить";
            this.btnDob.UseVisualStyleBackColor = true;
            this.btnDob.Click += new System.EventHandler(this.btnDob_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(256, 298);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(175, 75);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Очистить таблицу";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnTabl
            // 
            this.btnTabl.Location = new System.Drawing.Point(256, 191);
            this.btnTabl.Name = "btnTabl";
            this.btnTabl.Size = new System.Drawing.Size(175, 75);
            this.btnTabl.TabIndex = 9;
            this.btnTabl.Text = "Показать таблицу";
            this.btnTabl.UseVisualStyleBackColor = true;
            this.btnTabl.Click += new System.EventHandler(this.btnTabl_Click);
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(31, 272);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(175, 75);
            this.btnPoisk.TabIndex = 9;
            this.btnPoisk.Text = "Поиск по остановке";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // btnOch
            // 
            this.btnOch.Location = new System.Drawing.Point(256, 83);
            this.btnOch.Name = "btnOch";
            this.btnOch.Size = new System.Drawing.Size(175, 75);
            this.btnOch.TabIndex = 10;
            this.btnOch.Text = "Очистить поля ввода";
            this.btnOch.UseVisualStyleBackColor = true;
            this.btnOch.Click += new System.EventHandler(this.btnOch_Click);
            // 
            // RaspisDvizh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 386);
            this.Controls.Add(this.btnOch);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.btnTabl);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDob);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "RaspisDvizh";
            this.Text = "Расписание движения";
            this.Load += new System.EventHandler(this.RaspisDvizh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDob;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnTabl;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.Button btnOch;
    }
}
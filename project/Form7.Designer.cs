
namespace проект
{
    partial class Transp
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
            this.btnDob = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.btnOch = new System.Windows.Forms.Button();
            this.btnTabl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(641, 401);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Транспорт";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Маршрут транспорта";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 22);
            this.textBox3.TabIndex = 4;
            // 
            // btnDob
            // 
            this.btnDob.Location = new System.Drawing.Point(35, 175);
            this.btnDob.Name = "btnDob";
            this.btnDob.Size = new System.Drawing.Size(153, 63);
            this.btnDob.TabIndex = 5;
            this.btnDob.Text = "Добавить";
            this.btnDob.UseVisualStyleBackColor = true;
            this.btnDob.Click += new System.EventHandler(this.btnDob_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(227, 263);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(153, 63);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Очистить таблицу";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(35, 263);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(153, 63);
            this.btnPoisk.TabIndex = 5;
            this.btnPoisk.Text = "Поиск по транспорту";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // btnOch
            // 
            this.btnOch.Location = new System.Drawing.Point(227, 175);
            this.btnOch.Name = "btnOch";
            this.btnOch.Size = new System.Drawing.Size(153, 63);
            this.btnOch.TabIndex = 5;
            this.btnOch.Text = "Очистить поля ввода";
            this.btnOch.UseVisualStyleBackColor = true;
            this.btnOch.Click += new System.EventHandler(this.btnOch_Click);
            // 
            // btnTabl
            // 
            this.btnTabl.Location = new System.Drawing.Point(131, 350);
            this.btnTabl.Name = "btnTabl";
            this.btnTabl.Size = new System.Drawing.Size(153, 63);
            this.btnTabl.TabIndex = 5;
            this.btnTabl.Text = "Показать таблицу";
            this.btnTabl.UseVisualStyleBackColor = true;
            this.btnTabl.Click += new System.EventHandler(this.btnTabl_Click);
            // 
            // Transp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 426);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnTabl);
            this.Controls.Add(this.btnOch);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.btnDob);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Transp";
            this.Text = "Транспорт";
            this.Load += new System.EventHandler(this.Transp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnDob;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.Button btnOch;
        private System.Windows.Forms.Button btnTabl;
    }
}
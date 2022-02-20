
namespace проект
{
    partial class Vid
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
            this.tbResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnDob = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.btnTabl = new System.Windows.Forms.Button();
            this.btnOch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(423, 12);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResults.Size = new System.Drawing.Size(599, 329);
            this.tbResults.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена талона";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 22);
            this.textBox3.TabIndex = 4;
            // 
            // btnDob
            // 
            this.btnDob.Location = new System.Drawing.Point(48, 142);
            this.btnDob.Name = "btnDob";
            this.btnDob.Size = new System.Drawing.Size(146, 71);
            this.btnDob.TabIndex = 5;
            this.btnDob.Text = "Добавить";
            this.btnDob.UseVisualStyleBackColor = true;
            this.btnDob.Click += new System.EventHandler(this.btnDob_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(257, 244);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(146, 71);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Очистить таблицу";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(48, 244);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(146, 71);
            this.btnPoisk.TabIndex = 7;
            this.btnPoisk.Text = "Поиск по виду";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // btnTabl
            // 
            this.btnTabl.Location = new System.Drawing.Point(257, 142);
            this.btnTabl.Name = "btnTabl";
            this.btnTabl.Size = new System.Drawing.Size(146, 71);
            this.btnTabl.TabIndex = 8;
            this.btnTabl.Text = "Показать таблицу";
            this.btnTabl.UseVisualStyleBackColor = true;
            this.btnTabl.Click += new System.EventHandler(this.btnTabl_Click);
            // 
            // btnOch
            // 
            this.btnOch.Location = new System.Drawing.Point(257, 29);
            this.btnOch.Name = "btnOch";
            this.btnOch.Size = new System.Drawing.Size(146, 71);
            this.btnOch.TabIndex = 9;
            this.btnOch.Text = "Очистить поля ввода";
            this.btnOch.UseVisualStyleBackColor = true;
            this.btnOch.Click += new System.EventHandler(this.btnOch_Click);
            // 
            // Vid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 346);
            this.Controls.Add(this.btnOch);
            this.Controls.Add(this.btnTabl);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDob);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResults);
            this.Name = "Vid";
            this.Text = "Вид";
            this.Load += new System.EventHandler(this.Vid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnDob;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.Button btnTabl;
        private System.Windows.Forms.Button btnOch;
    }
}
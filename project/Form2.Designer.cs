
namespace проект
{
    partial class Base
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
            this.btnTransp = new System.Windows.Forms.Button();
            this.btnRaspis = new System.Windows.Forms.Button();
            this.btnVid = new System.Windows.Forms.Button();
            this.btnKoshel = new System.Windows.Forms.Button();
            this.btnOstan = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnTalon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransp
            // 
            this.btnTransp.Location = new System.Drawing.Point(73, 32);
            this.btnTransp.Name = "btnTransp";
            this.btnTransp.Size = new System.Drawing.Size(128, 55);
            this.btnTransp.TabIndex = 0;
            this.btnTransp.Text = "Транспорт";
            this.btnTransp.UseVisualStyleBackColor = true;
            this.btnTransp.Click += new System.EventHandler(this.btnTransp_Click);
            // 
            // btnRaspis
            // 
            this.btnRaspis.Location = new System.Drawing.Point(234, 210);
            this.btnRaspis.Name = "btnRaspis";
            this.btnRaspis.Size = new System.Drawing.Size(128, 55);
            this.btnRaspis.TabIndex = 1;
            this.btnRaspis.Text = "Расписание движения";
            this.btnRaspis.UseVisualStyleBackColor = true;
            this.btnRaspis.Click += new System.EventHandler(this.btnRaspis_Click);
            // 
            // btnVid
            // 
            this.btnVid.Location = new System.Drawing.Point(234, 32);
            this.btnVid.Name = "btnVid";
            this.btnVid.Size = new System.Drawing.Size(128, 55);
            this.btnVid.TabIndex = 2;
            this.btnVid.Text = "Вид";
            this.btnVid.UseVisualStyleBackColor = true;
            this.btnVid.Click += new System.EventHandler(this.btnVid_Click);
            // 
            // btnKoshel
            // 
            this.btnKoshel.Location = new System.Drawing.Point(73, 118);
            this.btnKoshel.Name = "btnKoshel";
            this.btnKoshel.Size = new System.Drawing.Size(128, 55);
            this.btnKoshel.TabIndex = 3;
            this.btnKoshel.Text = "Кошелек";
            this.btnKoshel.UseVisualStyleBackColor = true;
            this.btnKoshel.Click += new System.EventHandler(this.btnKoshel_Click);
            // 
            // btnOstan
            // 
            this.btnOstan.Location = new System.Drawing.Point(234, 118);
            this.btnOstan.Name = "btnOstan";
            this.btnOstan.Size = new System.Drawing.Size(128, 55);
            this.btnOstan.TabIndex = 4;
            this.btnOstan.Text = "Остановка";
            this.btnOstan.UseVisualStyleBackColor = true;
            this.btnOstan.Click += new System.EventHandler(this.btnOstan_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(73, 210);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(128, 55);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Пользователь";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnTalon
            // 
            this.btnTalon.Location = new System.Drawing.Point(150, 294);
            this.btnTalon.Name = "btnTalon";
            this.btnTalon.Size = new System.Drawing.Size(128, 55);
            this.btnTalon.TabIndex = 6;
            this.btnTalon.Text = "Талон";
            this.btnTalon.UseVisualStyleBackColor = true;
            this.btnTalon.Click += new System.EventHandler(this.btnTalon_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 375);
            this.Controls.Add(this.btnTalon);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnOstan);
            this.Controls.Add(this.btnKoshel);
            this.Controls.Add(this.btnVid);
            this.Controls.Add(this.btnRaspis);
            this.Controls.Add(this.btnTransp);
            this.Name = "Base";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransp;
        private System.Windows.Forms.Button btnRaspis;
        private System.Windows.Forms.Button btnVid;
        private System.Windows.Forms.Button btnKoshel;
        private System.Windows.Forms.Button btnOstan;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnTalon;
    }
}
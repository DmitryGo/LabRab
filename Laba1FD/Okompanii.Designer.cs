namespace Laba1FD
{
    partial class Okompanii
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.lbUrAd = new System.Windows.Forms.Label();
            this.lbIOD = new System.Windows.Forms.Label();
            this.lbKon = new System.Windows.Forms.Label();
            this.lbIOP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о деятельности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Юредический адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Контакты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Информация о партнерах:";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(429, 264);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbUrAd
            // 
            this.lbUrAd.AutoSize = true;
            this.lbUrAd.Location = new System.Drawing.Point(170, 78);
            this.lbUrAd.Name = "lbUrAd";
            this.lbUrAd.Size = new System.Drawing.Size(0, 13);
            this.lbUrAd.TabIndex = 5;
            // 
            // lbIOD
            // 
            this.lbIOD.AutoSize = true;
            this.lbIOD.Location = new System.Drawing.Point(170, 0);
            this.lbIOD.Name = "lbIOD";
            this.lbIOD.Size = new System.Drawing.Size(0, 13);
            this.lbIOD.TabIndex = 6;
            // 
            // lbKon
            // 
            this.lbKon.AutoSize = true;
            this.lbKon.Location = new System.Drawing.Point(170, 142);
            this.lbKon.Name = "lbKon";
            this.lbKon.Size = new System.Drawing.Size(0, 13);
            this.lbKon.TabIndex = 7;
            // 
            // lbIOP
            // 
            this.lbIOP.AutoSize = true;
            this.lbIOP.Location = new System.Drawing.Point(170, 214);
            this.lbIOP.Name = "lbIOP";
            this.lbIOP.Size = new System.Drawing.Size(0, 13);
            this.lbIOP.TabIndex = 8;
            // 
            // Okompanii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 302);
            this.Controls.Add(this.lbIOP);
            this.Controls.Add(this.lbKon);
            this.Controls.Add(this.lbIOD);
            this.Controls.Add(this.lbUrAd);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Okompanii";
            this.Text = "О компании";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Okompanii_FormClosing);
            this.Load += new System.EventHandler(this.Okompanii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbUrAd;
        private System.Windows.Forms.Label lbIOD;
        private System.Windows.Forms.Label lbKon;
        private System.Windows.Forms.Label lbIOP;
    }
}
namespace Laba1FD
{
    partial class Klient
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
            this.btTZ = new System.Windows.Forms.Button();
            this.btPrice = new System.Windows.Forms.Button();
            this.btSviz = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTZ
            // 
            this.btTZ.Location = new System.Drawing.Point(12, 12);
            this.btTZ.Name = "btTZ";
            this.btTZ.Size = new System.Drawing.Size(233, 23);
            this.btTZ.TabIndex = 0;
            this.btTZ.Text = "Составить техническое задание";
            this.btTZ.UseVisualStyleBackColor = true;
            this.btTZ.Click += new System.EventHandler(this.btTZ_Click);
            // 
            // btPrice
            // 
            this.btPrice.Location = new System.Drawing.Point(12, 41);
            this.btPrice.Name = "btPrice";
            this.btPrice.Size = new System.Drawing.Size(233, 23);
            this.btPrice.TabIndex = 1;
            this.btPrice.Text = "Прайс-лист";
            this.btPrice.UseVisualStyleBackColor = true;
            this.btPrice.Click += new System.EventHandler(this.btPrice_Click);
            // 
            // btSviz
            // 
            this.btSviz.Location = new System.Drawing.Point(12, 70);
            this.btSviz.Name = "btSviz";
            this.btSviz.Size = new System.Drawing.Size(233, 23);
            this.btSviz.TabIndex = 2;
            this.btSviz.Text = "Связь с разработчиком";
            this.btSviz.UseVisualStyleBackColor = true;
            this.btSviz.Click += new System.EventHandler(this.btSviz_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(170, 99);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 129);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btSviz);
            this.Controls.Add(this.btPrice);
            this.Controls.Add(this.btTZ);
            this.Name = "Klient";
            this.Text = "Клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Klient_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTZ;
        private System.Windows.Forms.Button btPrice;
        private System.Windows.Forms.Button btSviz;
        private System.Windows.Forms.Button btBack;
    }
}
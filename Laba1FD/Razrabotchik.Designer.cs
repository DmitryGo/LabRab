namespace Laba1FD
{
    partial class Razrabotchik
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
            this.btBack = new System.Windows.Forms.Button();
            this.btSpisZak = new System.Windows.Forms.Button();
            this.btKorPrice = new System.Windows.Forms.Button();
            this.btSvKlient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(143, 99);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btSpisZak
            // 
            this.btSpisZak.Location = new System.Drawing.Point(4, 12);
            this.btSpisZak.Name = "btSpisZak";
            this.btSpisZak.Size = new System.Drawing.Size(214, 23);
            this.btSpisZak.TabIndex = 6;
            this.btSpisZak.Text = "Список заказов";
            this.btSpisZak.UseVisualStyleBackColor = true;
            this.btSpisZak.Click += new System.EventHandler(this.btSpisZak_Click);
            // 
            // btKorPrice
            // 
            this.btKorPrice.Location = new System.Drawing.Point(4, 70);
            this.btKorPrice.Name = "btKorPrice";
            this.btKorPrice.Size = new System.Drawing.Size(214, 23);
            this.btKorPrice.TabIndex = 7;
            this.btKorPrice.Text = "Корректировка прайс-листа";
            this.btKorPrice.UseVisualStyleBackColor = true;
            this.btKorPrice.Click += new System.EventHandler(this.btKorPrice_Click);
            // 
            // btSvKlient
            // 
            this.btSvKlient.Location = new System.Drawing.Point(4, 41);
            this.btSvKlient.Name = "btSvKlient";
            this.btSvKlient.Size = new System.Drawing.Size(214, 23);
            this.btSvKlient.TabIndex = 8;
            this.btSvKlient.Text = "Связь с клиентом";
            this.btSvKlient.UseVisualStyleBackColor = true;
            this.btSvKlient.Click += new System.EventHandler(this.btSvKlient_Click);
            // 
            // Razrabotchik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 130);
            this.Controls.Add(this.btSvKlient);
            this.Controls.Add(this.btKorPrice);
            this.Controls.Add(this.btSpisZak);
            this.Controls.Add(this.btBack);
            this.Name = "Razrabotchik";
            this.Text = "Разработчик";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btSpisZak;
        private System.Windows.Forms.Button btKorPrice;
        private System.Windows.Forms.Button btSvKlient;
    }
}
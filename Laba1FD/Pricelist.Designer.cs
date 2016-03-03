namespace Laba1FD
{
    partial class Pricelist
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
            this.bt1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(282, 476);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(138, 34);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Назад";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(10, 11);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(410, 459);
            this.lb1.TabIndex = 2;
            // 
            // Pricelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 515);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.bt1);
            this.Name = "Pricelist";
            this.Text = "Pricelist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pricelist_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.ListBox lb1;
    }
}
namespace Laba1FD
{
    partial class SpisZak
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(7, 8);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(330, 498);
            this.lb1.TabIndex = 0;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(353, 8);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(547, 459);
            this.lb2.TabIndex = 1;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(771, 478);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(128, 27);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "Назад";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // SpisZak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 514);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "SpisZak";
            this.Text = "SpisZak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpisZak_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button bt1;
    }
}
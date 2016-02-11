namespace Laba1FD
{
    partial class Form2
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
            this.btVhod = new System.Windows.Forms.Button();
            this.btReg = new System.Windows.Forms.Button();
            this.tbPas = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btVhod
            // 
            this.btVhod.Location = new System.Drawing.Point(12, 64);
            this.btVhod.Name = "btVhod";
            this.btVhod.Size = new System.Drawing.Size(261, 42);
            this.btVhod.TabIndex = 0;
            this.btVhod.Text = "Вход";
            this.btVhod.UseVisualStyleBackColor = true;
            // 
            // btReg
            // 
            this.btReg.Location = new System.Drawing.Point(12, 112);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(261, 46);
            this.btReg.TabIndex = 1;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            // 
            // tbPas
            // 
            this.tbPas.Location = new System.Drawing.Point(109, 38);
            this.tbPas.Name = "tbPas";
            this.tbPas.Size = new System.Drawing.Size(164, 20);
            this.tbPas.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(164, 20);
            this.tbName.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 170);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPas);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.btVhod);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVhod;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.TextBox tbPas;
        private System.Windows.Forms.TextBox tbName;
    }
}
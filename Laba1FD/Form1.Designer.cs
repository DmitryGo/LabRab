namespace Laba1FD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAvtor = new System.Windows.Forms.Button();
            this.btOkomp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAvtor
            // 
            this.btAvtor.Location = new System.Drawing.Point(91, 104);
            this.btAvtor.Name = "btAvtor";
            this.btAvtor.Size = new System.Drawing.Size(129, 40);
            this.btAvtor.TabIndex = 0;
            this.btAvtor.Text = "Авторизация";
            this.btAvtor.UseVisualStyleBackColor = true;
            this.btAvtor.Click += new System.EventHandler(this.btAvtor_Click);
            // 
            // btOkomp
            // 
            this.btOkomp.Location = new System.Drawing.Point(91, 150);
            this.btOkomp.Name = "btOkomp";
            this.btOkomp.Size = new System.Drawing.Size(129, 42);
            this.btOkomp.TabIndex = 1;
            this.btOkomp.Text = "О компании";
            this.btOkomp.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btOkomp);
            this.Controls.Add(this.btAvtor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAvtor;
        private System.Windows.Forms.Button btOkomp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


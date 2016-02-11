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
            this.btAvtor = new System.Windows.Forms.Button();
            this.btOkomp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAvtor
            // 
            this.btAvtor.Location = new System.Drawing.Point(12, 93);
            this.btAvtor.Name = "btAvtor";
            this.btAvtor.Size = new System.Drawing.Size(129, 40);
            this.btAvtor.TabIndex = 0;
            this.btAvtor.Text = "Авторизация";
            this.btAvtor.UseVisualStyleBackColor = true;
            // 
            // btOkomp
            // 
            this.btOkomp.Location = new System.Drawing.Point(12, 139);
            this.btOkomp.Name = "btOkomp";
            this.btOkomp.Size = new System.Drawing.Size(129, 42);
            this.btOkomp.TabIndex = 1;
            this.btOkomp.Text = "О компании";
            this.btOkomp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 300);
            this.Controls.Add(this.btOkomp);
            this.Controls.Add(this.btAvtor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAvtor;
        private System.Windows.Forms.Button btOkomp;
    }
}


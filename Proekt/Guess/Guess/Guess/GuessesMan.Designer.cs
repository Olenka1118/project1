namespace Guess
{
    partial class GuessesMan
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.reference = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reference
            // 
            this.reference.AutoSize = true;
            this.reference.Location = new System.Drawing.Point(78, 49);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(46, 17);
            this.reference.TabIndex = 1;
            this.reference.Text = "label1";
            this.reference.Click += new System.EventHandler(this.reference_Click);
            // 
            // GuessesMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.reference);
            this.Name = "GuessesMan";
            this.Size = new System.Drawing.Size(493, 341);
            this.Load += new System.EventHandler(this.GuessesMan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label reference;
    }
}

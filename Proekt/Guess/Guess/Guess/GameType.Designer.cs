namespace Guess
{
    partial class GameType
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
            this.Level1 = new System.Windows.Forms.Button();
            this.Level2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputNumber = new System.Windows.Forms.TextBox();
            this.Think = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.More = new System.Windows.Forms.Label();
            this.Attempt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Level1
            // 
            this.Level1.BackColor = System.Drawing.Color.Yellow;
            this.Level1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level1.Location = new System.Drawing.Point(24, 22);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(141, 45);
            this.Level1.TabIndex = 0;
            this.Level1.Text = "Уровень 1";
            this.Level1.UseVisualStyleBackColor = false;
            this.Level1.Click += new System.EventHandler(this.Level1_Click);
            // 
            // Level2
            // 
            this.Level2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Level2.Enabled = false;
            this.Level2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level2.Location = new System.Drawing.Point(184, 22);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(141, 45);
            this.Level2.TabIndex = 1;
            this.Level2.Text = "Уровень 2";
            this.Level2.UseVisualStyleBackColor = false;
            this.Level2.Click += new System.EventHandler(this.Level2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(361, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // InputNumber
            // 
            this.InputNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InputNumber.Location = new System.Drawing.Point(349, 22);
            this.InputNumber.MaxLength = 1001;
            this.InputNumber.Multiline = true;
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(70, 322);
            this.InputNumber.TabIndex = 3;
            this.InputNumber.TextChanged += new System.EventHandler(this.InputNumber_TextChanged);
            // 
            // Think
            // 
            this.Think.AutoSize = true;
            this.Think.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Think.ForeColor = System.Drawing.Color.Navy;
            this.Think.Location = new System.Drawing.Point(61, 85);
            this.Think.Name = "Think";
            this.Think.Size = new System.Drawing.Size(200, 45);
            this.Think.TabIndex = 4;
            this.Think.Text = "Загадайте";
            this.Think.Click += new System.EventHandler(this.Think_Click);
            // 
            // Choose
            // 
            this.Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Choose.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choose.ForeColor = System.Drawing.Color.White;
            this.Choose.Location = new System.Drawing.Point(229, 260);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(83, 56);
            this.Choose.TabIndex = 5;
            this.Choose.Text = "OK";
            this.Choose.UseVisualStyleBackColor = false;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Times New Roman", 31.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Number.Location = new System.Drawing.Point(144, 260);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(50, 67);
            this.Number.TabIndex = 6;
            this.Number.TextChanged += new System.EventHandler(this.Number_TextChanged);
            this.Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // More
            // 
            this.More.AutoSize = true;
            this.More.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.More.ForeColor = System.Drawing.Color.Red;
            this.More.Location = new System.Drawing.Point(120, 172);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(132, 17);
            this.More.TabIndex = 7;
            this.More.Text = "                               ";
            this.More.Click += new System.EventHandler(this.More_Click);
            // 
            // Attempt
            // 
            this.Attempt.AutoSize = true;
            this.Attempt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Attempt.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attempt.ForeColor = System.Drawing.Color.Navy;
            this.Attempt.Location = new System.Drawing.Point(16, 275);
            this.Attempt.Name = "Attempt";
            this.Attempt.Size = new System.Drawing.Size(117, 46);
            this.Attempt.TabIndex = 8;
            this.Attempt.Text = "label2";
            this.Attempt.Click += new System.EventHandler(this.Attempt_Click);
            // 
            // GameType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.Attempt);
            this.Controls.Add(this.More);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.Think);
            this.Controls.Add(this.InputNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Level2);
            this.Controls.Add(this.Level1);
            this.Name = "GameType";
            this.Size = new System.Drawing.Size(454, 371);
            this.Load += new System.EventHandler(this.GameType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Level1;
        private System.Windows.Forms.Button Level2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputNumber;
        private System.Windows.Forms.Label Think;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label More;
        private System.Windows.Forms.Label Attempt;
    }
}

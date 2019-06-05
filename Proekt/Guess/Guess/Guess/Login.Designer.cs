namespace Guess
{
    partial class Login
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
            this.Name1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.Location = new System.Drawing.Point(28, 29);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(83, 37);
            this.Name1.TabIndex = 0;
            this.Name1.Text = "Имя";
            this.Name1.Click += new System.EventHandler(this.Name1_Click);
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User.Location = new System.Drawing.Point(118, 26);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(219, 45);
            this.User.TabIndex = 1;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Ok.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(205, 87);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(90, 45);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "ОК";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(378, 153);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Name1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логин";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Button Ok;
    }
}
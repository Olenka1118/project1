namespace Guess
{
    partial class TheInitialWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheInitialWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginСначалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.choiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManGuessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.ComputerGuessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_window = new System.Windows.Forms.Panel();
            this.subscriber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.main_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failsToolStripMenuItem
            // 
            this.failsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginСначалаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.topToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.failsToolStripMenuItem.Name = "failsToolStripMenuItem";
            this.failsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.failsToolStripMenuItem.Text = "Файл";
            // 
            // beginСначалаToolStripMenuItem
            // 
            this.beginСначалаToolStripMenuItem.Name = "beginСначалаToolStripMenuItem";
            this.beginСначалаToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.beginСначалаToolStripMenuItem.Text = "Начать сначала";
            this.beginСначалаToolStripMenuItem.Click += new System.EventHandler(this.BeginСначалаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.topToolStripMenuItem.Text = "Рейтинг играков ";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.TopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.toolStripMenuItem4,
            this.choiceToolStripMenuItem,
            this.toolStripMenuItem5,
            this.removeToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.customersToolStripMenuItem.Text = "Пользователи";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 6);
            // 
            // choiceToolStripMenuItem
            // 
            this.choiceToolStripMenuItem.Name = "choiceToolStripMenuItem";
            this.choiceToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.choiceToolStripMenuItem.Text = "Выбрать";
            this.choiceToolStripMenuItem.Click += new System.EventHandler(this.ChoiceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(213, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.removeToolStripMenuItem.Text = "Удалить";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManGuessesToolStripMenuItem,
            this.toolStripMenuItem6,
            this.ComputerGuessesToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.typeToolStripMenuItem.Text = "Вид";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.TypeToolStripMenuItem_Click);
            // 
            // ManGuessesToolStripMenuItem
            // 
            this.ManGuessesToolStripMenuItem.Name = "ManGuessesToolStripMenuItem";
            this.ManGuessesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.ManGuessesToolStripMenuItem.Text = "Человек угадывает";
            this.ManGuessesToolStripMenuItem.Click += new System.EventHandler(this.ManGuessesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(236, 6);
            // 
            // ComputerGuessesToolStripMenuItem
            // 
            this.ComputerGuessesToolStripMenuItem.Name = "ComputerGuessesToolStripMenuItem";
            this.ComputerGuessesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.ComputerGuessesToolStripMenuItem.Text = "Компьютер угадывает";
            this.ComputerGuessesToolStripMenuItem.Click += new System.EventHandler(this.ComputerGuessesToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruleToolStripMenuItem,
            this.toolStripMenuItem7,
            this.creatorToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.HelpToolStripMenuItem.Text = "Справка";
            // 
            // ruleToolStripMenuItem
            // 
            this.ruleToolStripMenuItem.Name = "ruleToolStripMenuItem";
            this.ruleToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.ruleToolStripMenuItem.Text = "Правило игры";
            this.ruleToolStripMenuItem.Click += new System.EventHandler(this.RuleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(182, 6);
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.creatorToolStripMenuItem.Text = "Создатели";
            this.creatorToolStripMenuItem.Click += new System.EventHandler(this.CreatorToolStripMenuItem_Click);
            // 
            // main_window
            // 
            this.main_window.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_window.BackgroundImage")));
            this.main_window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_window.Controls.Add(this.subscriber);
            this.main_window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_window.Location = new System.Drawing.Point(0, 28);
            this.main_window.Name = "main_window";
            this.main_window.Size = new System.Drawing.Size(850, 476);
            this.main_window.TabIndex = 1;
            this.main_window.SizeChanged += new System.EventHandler(this.Main_window_SizeChanged);
            this.main_window.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_window_Paint);
            // 
            // subscriber
            // 
            this.subscriber.AutoSize = true;
            this.subscriber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.subscriber.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriber.Location = new System.Drawing.Point(207, 151);
            this.subscriber.Name = "subscriber";
            this.subscriber.Size = new System.Drawing.Size(0, 55);
            this.subscriber.TabIndex = 0;
            this.subscriber.Click += new System.EventHandler(this.Subscriber_Click);
            // 
            // TheInitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 504);
            this.Controls.Add(this.main_window);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TheInitialWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадайка";
            this.Activated += new System.EventHandler(this.TheInitialWindow_Activated);
            this.Load += new System.EventHandler(this.Guess_Load);
            this.Resize += new System.EventHandler(this.TheInitialWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.main_window.ResumeLayout(false);
            this.main_window.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginСначалаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem choiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManGuessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ComputerGuessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private System.Windows.Forms.Panel main_window;
        private System.Windows.Forms.Label subscriber;
    }
}


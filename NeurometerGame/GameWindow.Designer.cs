namespace NeurometerGame
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.startButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.minutes = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerPanel = new System.Windows.Forms.Panel();
            this.timer = new System.Timers.Timer();
            this.resetPanel = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGameSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGameImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionsColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionsColor0 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionsColor1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGame = new System.Windows.Forms.SaveFileDialog();
            this.openGame = new System.Windows.Forms.OpenFileDialog();
            this.gamePanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.resetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(230)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(136)))), ((int)(((byte)(220)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(20, 20);
            this.startButton.Margin = new System.Windows.Forms.Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 100);
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.Color.White;
            this.endButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(230)))));
            this.endButton.FlatAppearance.BorderSize = 3;
            this.endButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.endButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.endButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(230)))));
            this.endButton.Location = new System.Drawing.Point(820, 430);
            this.endButton.Margin = new System.Windows.Forms.Padding(0);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(100, 100);
            this.endButton.TabIndex = 1;
            this.endButton.TabStop = false;
            this.endButton.Text = "end";
            this.endButton.UseVisualStyleBackColor = false;
            this.endButton.MouseEnter += new System.EventHandler(this.endButton_MouseEnter);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gamePanel.Controls.Add(this.endButton);
            this.gamePanel.Controls.Add(this.startButton);
            this.gamePanel.Location = new System.Drawing.Point(30, 120);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(940, 550);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.MouseEnter += new System.EventHandler(this.gamePanel_MouseEnter);
            // 
            // minutes
            // 
            this.minutes.BackColor = System.Drawing.Color.Transparent;
            this.minutes.Location = new System.Drawing.Point(0, 0);
            this.minutes.Margin = new System.Windows.Forms.Padding(0);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(50, 50);
            this.minutes.TabIndex = 0;
            this.minutes.Text = "00";
            this.minutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.Transparent;
            this.second.Location = new System.Drawing.Point(70, 0);
            this.second.Margin = new System.Windows.Forms.Padding(0);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(100, 50);
            this.second.TabIndex = 1;
            this.second.Text = "0.0";
            this.second.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPanel
            // 
            this.timerPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.timerPanel.Controls.Add(this.label1);
            this.timerPanel.Controls.Add(this.second);
            this.timerPanel.Controls.Add(this.minutes);
            this.timerPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.timerPanel.Location = new System.Drawing.Point(50, 55);
            this.timerPanel.Name = "timerPanel";
            this.timerPanel.Size = new System.Drawing.Size(170, 50);
            this.timerPanel.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1D;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // resetPanel
            // 
            this.resetPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(230)))));
            this.resetPanel.Controls.Add(this.reset);
            this.resetPanel.Location = new System.Drawing.Point(900, 55);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(50, 50);
            this.resetPanel.TabIndex = 3;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Image = global::NeurometerGame.Properties.Resources.reset;
            this.reset.Location = new System.Drawing.Point(0, 0);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(50, 50);
            this.reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reset.TabIndex = 4;
            this.reset.TabStop = false;
            this.reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reset_MouseDown);
            this.reset.MouseEnter += new System.EventHandler(this.reset_MouseEnter);
            this.reset.MouseLeave += new System.EventHandler(this.reset_MouseLeave);
            this.reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reset_MouseUp);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuGame, this.menuOptions });
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1000, 40);
            this.menu.TabIndex = 4;
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuGameSave, this.menuGameImport });
            this.menuGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.menuGame.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuGame.Name = "menuGame";
            this.menuGame.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.menuGame.Size = new System.Drawing.Size(70, 32);
            this.menuGame.Text = "Game";
            // 
            // menuGameSave
            // 
            this.menuGameSave.BackColor = System.Drawing.Color.White;
            this.menuGameSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.menuGameSave.Name = "menuGameSave";
            this.menuGameSave.Size = new System.Drawing.Size(152, 28);
            this.menuGameSave.Text = "Save";
            this.menuGameSave.Click += new System.EventHandler(this.menuGameSave_Click);
            // 
            // menuGameImport
            // 
            this.menuGameImport.BackColor = System.Drawing.Color.White;
            this.menuGameImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.menuGameImport.Name = "menuGameImport";
            this.menuGameImport.Size = new System.Drawing.Size(152, 28);
            this.menuGameImport.Text = "Import";
            this.menuGameImport.Click += new System.EventHandler(this.menuGameImport_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuOptionsColor });
            this.menuOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.menuOptions.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.menuOptions.Size = new System.Drawing.Size(106, 32);
            this.menuOptions.Text = "Options";
            // 
            // menuOptionsColor
            // 
            this.menuOptionsColor.BackColor = System.Drawing.Color.White;
            this.menuOptionsColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuOptionsColor0, this.menuOptionsColor1 });
            this.menuOptionsColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.menuOptionsColor.Name = "menuOptionsColor";
            this.menuOptionsColor.Size = new System.Drawing.Size(140, 28);
            this.menuOptionsColor.Text = "Color";
            // 
            // menuOptionsColor0
            // 
            this.menuOptionsColor0.BackColor = System.Drawing.Color.White;
            this.menuOptionsColor0.Checked = true;
            this.menuOptionsColor0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuOptionsColor0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.menuOptionsColor0.Name = "menuOptionsColor0";
            this.menuOptionsColor0.Size = new System.Drawing.Size(140, 28);
            this.menuOptionsColor0.Text = "Blue";
            this.menuOptionsColor0.Click += new System.EventHandler(this.Colors_Click);
            // 
            // menuOptionsColor1
            // 
            this.menuOptionsColor1.BackColor = System.Drawing.Color.White;
            this.menuOptionsColor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.menuOptionsColor1.Name = "menuOptionsColor1";
            this.menuOptionsColor1.Size = new System.Drawing.Size(140, 28);
            this.menuOptionsColor1.Text = "Green";
            this.menuOptionsColor1.Click += new System.EventHandler(this.Colors_Click);
            // 
            // saveGame
            // 
            this.saveGame.FileName = "yor_game";
            this.saveGame.Filter = "NeurometerGame files (*.neurometer)|*.neurometer";
            this.saveGame.Title = "Saving your game";
            // 
            // openGame
            // 
            this.openGame.Filter = "NeurometerGame files (*.neurometer)|*.neurometer";
            this.openGame.Title = "Open yor game";
            // 
            // GameWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.resetPanel);
            this.Controls.Add(this.timerPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(1006, 735);
            this.MinimumSize = new System.Drawing.Size(1006, 735);
            this.Name = "GameWindow";
            this.Text = "Neuro Meter";
            this.gamePanel.ResumeLayout(false);
            this.timerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.resetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reset)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.OpenFileDialog openGame;

        private System.Windows.Forms.SaveFileDialog saveGame;

        private System.Windows.Forms.ToolStripMenuItem menuOptionsColor0;
        private System.Windows.Forms.ToolStripMenuItem menuOptionsColor1;

        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuOptionsColor;

        private System.Windows.Forms.ToolStripMenuItem menuGameSave;
        private System.Windows.Forms.ToolStripMenuItem menuGameImport;

        private System.Windows.Forms.ToolStripMenuItem menuGame;

        private System.Windows.Forms.MenuStrip menu;

        private System.Windows.Forms.PictureBox reset;

        private System.Windows.Forms.Panel resetPanel;

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel timerPanel;
        private System.Timers.Timer timer;

        #endregion
    }
}
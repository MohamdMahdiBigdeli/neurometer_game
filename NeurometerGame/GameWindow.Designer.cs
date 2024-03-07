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
            this.reset = new System.Windows.Forms.Button();
            this.minutes = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Panel();
            this.timer = new System.Timers.Timer();
            this.gamePanel.SuspendLayout();
            this.time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(142)))), ((int)(((byte)(230)))));
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
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.BackgroundImage = global::NeurometerGame.Properties.Resources.reset_up;
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Location = new System.Drawing.Point(900, 35);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(50, 50);
            this.reset.TabIndex = 1;
            this.reset.TabStop = false;
            this.reset.UseVisualStyleBackColor = false;
            this.reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reset_MouseDown);
            this.reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reset_MouseUp);
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
            // time
            // 
            this.time.BackColor = System.Drawing.Color.LightSkyBlue;
            this.time.Controls.Add(this.label1);
            this.time.Controls.Add(this.second);
            this.time.Controls.Add(this.minutes);
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.time.Location = new System.Drawing.Point(50, 35);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(170, 50);
            this.time.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1D;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // GameWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.time);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.gamePanel);
            this.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "GameWindow";
            this.Text = "Neuro Meter";
            this.gamePanel.ResumeLayout(false);
            this.time.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel time;
        private System.Timers.Timer timer;

        #endregion
    }
}
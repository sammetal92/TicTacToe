namespace TicTacToeAI
{
    partial class Form1
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
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.o_Radio = new System.Windows.Forms.RadioButton();
            this.x_Radio = new System.Windows.Forms.RadioButton();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.bottom_right = new System.Windows.Forms.Button();
            this.bottom_middle = new System.Windows.Forms.Button();
            this.bottom_left = new System.Windows.Forms.Button();
            this.middle_right = new System.Windows.Forms.Button();
            this.middle_middle = new System.Windows.Forms.Button();
            this.middle_left = new System.Windows.Forms.Button();
            this.top_right = new System.Windows.Forms.Button();
            this.top_middle = new System.Windows.Forms.Button();
            this.top_left = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionPanel
            // 
            this.selectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectionPanel.Controls.Add(this.stopButton);
            this.selectionPanel.Controls.Add(this.startButton);
            this.selectionPanel.Controls.Add(this.o_Radio);
            this.selectionPanel.Controls.Add(this.x_Radio);
            this.selectionPanel.Controls.Add(this.menuStrip1);
            this.selectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectionPanel.Location = new System.Drawing.Point(0, 0);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(353, 136);
            this.selectionPanel.TabIndex = 0;
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(177, 96);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop Game";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(81, 96);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // o_Radio
            // 
            this.o_Radio.AutoSize = true;
            this.o_Radio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_Radio.ForeColor = System.Drawing.Color.Blue;
            this.o_Radio.Location = new System.Drawing.Point(150, 65);
            this.o_Radio.Name = "o_Radio";
            this.o_Radio.Size = new System.Drawing.Size(42, 21);
            this.o_Radio.TabIndex = 1;
            this.o_Radio.TabStop = true;
            this.o_Radio.Text = " O";
            this.o_Radio.UseVisualStyleBackColor = true;
            // 
            // x_Radio
            // 
            this.x_Radio.AutoSize = true;
            this.x_Radio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_Radio.ForeColor = System.Drawing.Color.Red;
            this.x_Radio.Location = new System.Drawing.Point(151, 38);
            this.x_Radio.Name = "x_Radio";
            this.x_Radio.Size = new System.Drawing.Size(39, 21);
            this.x_Radio.TabIndex = 0;
            this.x_Radio.TabStop = true;
            this.x_Radio.Text = " X";
            this.x_Radio.UseVisualStyleBackColor = true;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.bottom_right);
            this.gamePanel.Controls.Add(this.bottom_middle);
            this.gamePanel.Controls.Add(this.bottom_left);
            this.gamePanel.Controls.Add(this.middle_right);
            this.gamePanel.Controls.Add(this.middle_middle);
            this.gamePanel.Controls.Add(this.middle_left);
            this.gamePanel.Controls.Add(this.top_right);
            this.gamePanel.Controls.Add(this.top_middle);
            this.gamePanel.Controls.Add(this.top_left);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 136);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(353, 331);
            this.gamePanel.TabIndex = 1;
            // 
            // bottom_right
            // 
            this.bottom_right.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.bottom_right.Location = new System.Drawing.Point(266, 233);
            this.bottom_right.Name = "bottom_right";
            this.bottom_right.Size = new System.Drawing.Size(75, 75);
            this.bottom_right.TabIndex = 8;
            this.bottom_right.UseVisualStyleBackColor = true;
            this.bottom_right.Click += new System.EventHandler(this.gameButton_click);
            // 
            // bottom_middle
            // 
            this.bottom_middle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.bottom_middle.Location = new System.Drawing.Point(142, 233);
            this.bottom_middle.Name = "bottom_middle";
            this.bottom_middle.Size = new System.Drawing.Size(75, 75);
            this.bottom_middle.TabIndex = 7;
            this.bottom_middle.UseVisualStyleBackColor = true;
            this.bottom_middle.Click += new System.EventHandler(this.gameButton_click);
            // 
            // bottom_left
            // 
            this.bottom_left.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.bottom_left.Location = new System.Drawing.Point(12, 233);
            this.bottom_left.Name = "bottom_left";
            this.bottom_left.Size = new System.Drawing.Size(75, 75);
            this.bottom_left.TabIndex = 6;
            this.bottom_left.UseVisualStyleBackColor = true;
            this.bottom_left.Click += new System.EventHandler(this.gameButton_click);
            // 
            // middle_right
            // 
            this.middle_right.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.middle_right.Location = new System.Drawing.Point(266, 127);
            this.middle_right.Name = "middle_right";
            this.middle_right.Size = new System.Drawing.Size(75, 75);
            this.middle_right.TabIndex = 5;
            this.middle_right.UseVisualStyleBackColor = true;
            this.middle_right.Click += new System.EventHandler(this.gameButton_click);
            // 
            // middle_middle
            // 
            this.middle_middle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.middle_middle.Location = new System.Drawing.Point(142, 127);
            this.middle_middle.Name = "middle_middle";
            this.middle_middle.Size = new System.Drawing.Size(75, 75);
            this.middle_middle.TabIndex = 4;
            this.middle_middle.UseVisualStyleBackColor = true;
            this.middle_middle.Click += new System.EventHandler(this.gameButton_click);
            // 
            // middle_left
            // 
            this.middle_left.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.middle_left.Location = new System.Drawing.Point(12, 127);
            this.middle_left.Name = "middle_left";
            this.middle_left.Size = new System.Drawing.Size(75, 75);
            this.middle_left.TabIndex = 3;
            this.middle_left.UseVisualStyleBackColor = true;
            this.middle_left.Click += new System.EventHandler(this.gameButton_click);
            // 
            // top_right
            // 
            this.top_right.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.top_right.Location = new System.Drawing.Point(266, 24);
            this.top_right.Name = "top_right";
            this.top_right.Size = new System.Drawing.Size(75, 75);
            this.top_right.TabIndex = 2;
            this.top_right.UseVisualStyleBackColor = true;
            this.top_right.Click += new System.EventHandler(this.gameButton_click);
            // 
            // top_middle
            // 
            this.top_middle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.top_middle.Location = new System.Drawing.Point(142, 24);
            this.top_middle.Name = "top_middle";
            this.top_middle.Size = new System.Drawing.Size(75, 75);
            this.top_middle.TabIndex = 1;
            this.top_middle.UseVisualStyleBackColor = true;
            this.top_middle.Click += new System.EventHandler(this.gameButton_click);
            // 
            // top_left
            // 
            this.top_left.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_left.Location = new System.Drawing.Point(12, 24);
            this.top_left.Name = "top_left";
            this.top_left.Size = new System.Drawing.Size(75, 75);
            this.top_left.TabIndex = 0;
            this.top_left.UseVisualStyleBackColor = true;
            this.top_left.Click += new System.EventHandler(this.gameButton_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 467);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.selectionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.selectionPanel.ResumeLayout(false);
            this.selectionPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectionPanel;
        private System.Windows.Forms.RadioButton x_Radio;
        private System.Windows.Forms.RadioButton o_Radio;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button top_right;
        private System.Windows.Forms.Button top_middle;
        private System.Windows.Forms.Button top_left;
        private System.Windows.Forms.Button bottom_right;
        private System.Windows.Forms.Button bottom_middle;
        private System.Windows.Forms.Button bottom_left;
        private System.Windows.Forms.Button middle_right;
        private System.Windows.Forms.Button middle_middle;
        private System.Windows.Forms.Button middle_left;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}


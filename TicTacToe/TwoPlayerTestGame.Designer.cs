namespace TicTacToe
{
	partial class TwoPlayerTestGame
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
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.boardPanel = new System.Windows.Forms.Panel();
			this.bottomRightSpace = new TicTacToe.Controls.Space();
			this.topLeftSpace = new TicTacToe.Controls.Space();
			this.topCenterSpace = new TicTacToe.Controls.Space();
			this.bottomCenterSpace = new TicTacToe.Controls.Space();
			this.bottomLeftSpace = new TicTacToe.Controls.Space();
			this.topRightSpace = new TicTacToe.Controls.Space();
			this.middleLeftSpace = new TicTacToe.Controls.Space();
			this.middleRightSpace = new TicTacToe.Controls.Space();
			this.middleCenterSpace = new TicTacToe.Controls.Space();
			this.MenuStrip.SuspendLayout();
			this.boardPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(507, 24);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mainMenuToolStripMenuItem
			// 
			this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
			this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.mainMenuToolStripMenuItem.Text = "Main Menu";
			this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 491);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(507, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// boardPanel
			// 
			this.boardPanel.Controls.Add(this.bottomRightSpace);
			this.boardPanel.Controls.Add(this.topLeftSpace);
			this.boardPanel.Controls.Add(this.topCenterSpace);
			this.boardPanel.Controls.Add(this.bottomCenterSpace);
			this.boardPanel.Controls.Add(this.bottomLeftSpace);
			this.boardPanel.Controls.Add(this.topRightSpace);
			this.boardPanel.Controls.Add(this.middleLeftSpace);
			this.boardPanel.Controls.Add(this.middleRightSpace);
			this.boardPanel.Controls.Add(this.middleCenterSpace);
			this.boardPanel.Location = new System.Drawing.Point(0, 27);
			this.boardPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
			this.boardPanel.Name = "boardPanel";
			this.boardPanel.Padding = new System.Windows.Forms.Padding(20);
			this.boardPanel.Size = new System.Drawing.Size(395, 380);
			this.boardPanel.TabIndex = 11;
			// 
			// bottomRightSpace
			// 
			this.bottomRightSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.bottomRightSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bottomRightSpace.Location = new System.Drawing.Point(264, 252);
			this.bottomRightSpace.Name = "bottomRightSpace";
			this.bottomRightSpace.Owner = '\0';
			this.bottomRightSpace.PositionX = 2;
			this.bottomRightSpace.PositionY = 2;
			this.bottomRightSpace.Size = new System.Drawing.Size(120, 120);
			this.bottomRightSpace.TabIndex = 10;
			this.bottomRightSpace.UseVisualStyleBackColor = false;
			this.bottomRightSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// topLeftSpace
			// 
			this.topLeftSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.topLeftSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.topLeftSpace.Location = new System.Drawing.Point(12, 0);
			this.topLeftSpace.Name = "topLeftSpace";
			this.topLeftSpace.Owner = '\0';
			this.topLeftSpace.PositionX = 0;
			this.topLeftSpace.PositionY = 0;
			this.topLeftSpace.Size = new System.Drawing.Size(120, 120);
			this.topLeftSpace.TabIndex = 0;
			this.topLeftSpace.UseVisualStyleBackColor = false;
			this.topLeftSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// topCenterSpace
			// 
			this.topCenterSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.topCenterSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.topCenterSpace.Location = new System.Drawing.Point(138, 0);
			this.topCenterSpace.Name = "topCenterSpace";
			this.topCenterSpace.Owner = '\0';
			this.topCenterSpace.PositionX = 1;
			this.topCenterSpace.PositionY = 0;
			this.topCenterSpace.Size = new System.Drawing.Size(120, 120);
			this.topCenterSpace.TabIndex = 3;
			this.topCenterSpace.UseVisualStyleBackColor = false;
			this.topCenterSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// bottomCenterSpace
			// 
			this.bottomCenterSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.bottomCenterSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bottomCenterSpace.Location = new System.Drawing.Point(138, 252);
			this.bottomCenterSpace.Name = "bottomCenterSpace";
			this.bottomCenterSpace.Owner = '\0';
			this.bottomCenterSpace.PositionX = 1;
			this.bottomCenterSpace.PositionY = 2;
			this.bottomCenterSpace.Size = new System.Drawing.Size(120, 120);
			this.bottomCenterSpace.TabIndex = 8;
			this.bottomCenterSpace.UseVisualStyleBackColor = false;
			this.bottomCenterSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// bottomLeftSpace
			// 
			this.bottomLeftSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.bottomLeftSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bottomLeftSpace.Location = new System.Drawing.Point(12, 252);
			this.bottomLeftSpace.Name = "bottomLeftSpace";
			this.bottomLeftSpace.Owner = '\0';
			this.bottomLeftSpace.PositionX = 0;
			this.bottomLeftSpace.PositionY = 2;
			this.bottomLeftSpace.Size = new System.Drawing.Size(120, 120);
			this.bottomLeftSpace.TabIndex = 9;
			this.bottomLeftSpace.UseVisualStyleBackColor = false;
			this.bottomLeftSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// topRightSpace
			// 
			this.topRightSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.topRightSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.topRightSpace.Location = new System.Drawing.Point(264, 0);
			this.topRightSpace.Name = "topRightSpace";
			this.topRightSpace.Owner = '\0';
			this.topRightSpace.PositionX = 2;
			this.topRightSpace.PositionY = 0;
			this.topRightSpace.Size = new System.Drawing.Size(120, 120);
			this.topRightSpace.TabIndex = 4;
			this.topRightSpace.UseVisualStyleBackColor = false;
			this.topRightSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// middleLeftSpace
			// 
			this.middleLeftSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.middleLeftSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.middleLeftSpace.Location = new System.Drawing.Point(12, 126);
			this.middleLeftSpace.Name = "middleLeftSpace";
			this.middleLeftSpace.Owner = '\0';
			this.middleLeftSpace.PositionX = 0;
			this.middleLeftSpace.PositionY = 1;
			this.middleLeftSpace.Size = new System.Drawing.Size(120, 120);
			this.middleLeftSpace.TabIndex = 5;
			this.middleLeftSpace.UseVisualStyleBackColor = false;
			this.middleLeftSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// middleRightSpace
			// 
			this.middleRightSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.middleRightSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.middleRightSpace.Location = new System.Drawing.Point(264, 126);
			this.middleRightSpace.Name = "middleRightSpace";
			this.middleRightSpace.Owner = '\0';
			this.middleRightSpace.PositionX = 2;
			this.middleRightSpace.PositionY = 1;
			this.middleRightSpace.Size = new System.Drawing.Size(120, 120);
			this.middleRightSpace.TabIndex = 7;
			this.middleRightSpace.UseVisualStyleBackColor = false;
			this.middleRightSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// middleCenterSpace
			// 
			this.middleCenterSpace.BackColor = System.Drawing.SystemColors.Menu;
			this.middleCenterSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.middleCenterSpace.Location = new System.Drawing.Point(138, 126);
			this.middleCenterSpace.Name = "middleCenterSpace";
			this.middleCenterSpace.Owner = '\0';
			this.middleCenterSpace.PositionX = 1;
			this.middleCenterSpace.PositionY = 1;
			this.middleCenterSpace.Size = new System.Drawing.Size(120, 120);
			this.middleCenterSpace.TabIndex = 6;
			this.middleCenterSpace.UseVisualStyleBackColor = false;
			this.middleCenterSpace.Click += new System.EventHandler(this.Space_Click);
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(507, 513);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.MenuStrip);
			this.Controls.Add(this.boardPanel);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "Game";
			this.Text = "Tic Tac Toe";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.boardPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.Space topLeftSpace;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private Controls.Space topCenterSpace;
		private Controls.Space topRightSpace;
		private Controls.Space middleLeftSpace;
		private Controls.Space middleCenterSpace;
		private Controls.Space middleRightSpace;
		private Controls.Space bottomCenterSpace;
		private Controls.Space bottomLeftSpace;
		private Controls.Space bottomRightSpace;
		private System.Windows.Forms.Panel boardPanel;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
	}
}
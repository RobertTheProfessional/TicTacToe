using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Engine;

namespace TicTacToe
{
	public partial class Game : Form
	{
		private Form mainMenu = null;
		private Logic game = null;

		public Game()
		{
			InitializeComponent();
			game = new Logic();
		}

		public Game(Form mainMenu) : this() { this.mainMenu = mainMenu; }

		#region Event Handlers

		private void Space_Click(object sender, EventArgs e)
		{
			var space = (Space)sender;

			// Attempt to set the space
			if (game.MarkBoardSpace(space))
			{
				// Set the current player as the owner
				// of the space then switch players
				space.Owner = game.CurrentPlayer;

				// Check for a winner
				if (game.CheckMoveForWin())
				{
					MessageBox.Show("Player " + game.CurrentPlayer + " won!");
					Environment.Exit(0);
				}

				// Check if the board is full
				if (game.IsBoardFull())
				{
					DialogResult response = MessageBox.Show("Board is full! Play another match?", "Game Over", MessageBoxButtons.YesNo);

					if (response == DialogResult.Yes)
					{
						// Reset Game Board
						game.ResetBoard();

						var spaces = this.Controls[boardPanel.Name].Controls.OfType<Space>();

						foreach (var spc in spaces)
							spc.Owner = 'E';
					}
					else if (response == DialogResult.No)
					{
						this.EndGame();
					}
					else
					{

					}
				}

				game.SwitchPlayer();
			}
			else
			{
				MessageBox.Show("Space is already taken!", "Wait a minute!", MessageBoxButtons.OK);
			}
		}

		private void Game_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (mainMenu != null)
				mainMenu.Show();
			else
				throw new Exception("Main Menu Not Implemented");
		}

		private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (mainMenu != null)
			{
				// End the Game
				this.Close();
			}
			else
			{
				throw new Exception("Main Menu Not Implemented");
			}		
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		#endregion

		#region Form Helpers

		private void EndGame()
		{
			this.Close();
		}

		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Controls;
using TicTacToe.Engine;

namespace TicTacToe
{
	public partial class TwoPlayerTestGame : Form
	{
		private Form mainMenu = null;
		private Logic game = null;

		public TwoPlayerTestGame()
		{
			InitializeComponent();
			game = new Logic();
		}

		public TwoPlayerTestGame(Form mainMenu) : this() { this.mainMenu = mainMenu; }

		#region Form Helpers

		private Boolean MarkBoardSpace(Space space)
		{
			return game.MarkBoardSpace(space.PositionX, space.PositionY);
		}

		private void PlayAnotherMatch(DialogResult response)
		{
			if (response == DialogResult.Yes)
			{
				// Reset Game Board
				game.ResetBoard();

				// Get a collection of all Space controls
				IEnumerable<Space> spaces = this.Controls[boardPanel.Name].Controls.OfType<Space>();

				// Reset each Space
				foreach (var spc in spaces)
					spc.Owner = 'E';
			}
			else if (response == DialogResult.No)
				this.EndGame();
		}

		private void EndGame() { this.Close(); }

		#endregion

		#region Event Handlers

		/// <summary>
		/// Handle a player's click and determine whether or not 
		/// the move was legal and if it was a winning play.
		/// </summary>
		/// <param name="sender">Space control which was clicked</param>
		/// <param name="e">Event Arguments</param>
		private void Space_Click(object sender, EventArgs e)
		{
			// Get the Space control
			var space = (Space)sender;

			// Attempt to set the space
			if (MarkBoardSpace(space))
			{
				// Set the current player as the owner
				// of the space then switch players
				space.Owner = game.CurrentPlayer;

				// Check for a winner
				if (game.CheckMoveForWin())
				{
					DialogResult response =
						MessageBox.Show("Player " + game.CurrentPlayer + " won! Play another match?", "We have a winner!", MessageBoxButtons.YesNo);
					PlayAnotherMatch(response);
				}

				// Check if the board is full
				if (game.IsBoardFull())
				{
					DialogResult response = MessageBox.Show("Board is full! Play another match?", "Game Over", MessageBoxButtons.YesNo);
					PlayAnotherMatch(response);
				}

				// Switch the current players
				game.SwitchPlayer();
			}
			else
				MessageBox.Show("Space is already taken!", "Wait a minute!", MessageBoxButtons.OK);
		}

		/// <summary>
		/// Show the main menu (if set) once the game is closed
		/// </summary>
		/// <param name="sender">Game Form control</param>
		/// <param name="e">Event Argument</param>
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
	}
}

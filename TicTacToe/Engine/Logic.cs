using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Engine
{
	public class Logic
	{
		private readonly Board board;
		public Char CurrentPlayer { get; private set; }

		public Logic()
		{
			board = new Board();
			CurrentPlayer = WhoMakesTheFirstMove();
		}

		/// <summary>
		/// Switch the current player
		/// </summary>
		public void SwitchPlayer()
		{
			CurrentPlayer = CurrentPlayer == 'X' ? 'O' : 'X';
		}

		/// <summary>
		/// Attempt to mark a board space with the current player's ID.
		/// </summary>
		/// <param name="positionX">Row position of the space</param>
		/// <param name="positionY">Column position of the space</param>
		/// <returns>True if space could successfully be marked by the current player, otherwise false</returns>
		public Boolean MarkBoardSpace(Int32 positionX, Int32 positionY)
		{
			// Check if board space is empty, if so mark
			// the space with the current player's mark.
			if (board.IsSpaceEmpty(positionX, positionY))
			{
				// Set the space
				board.SetSpaceValue(positionX, positionY, CurrentPlayer);
				return true;
			}

			return false;
		}

		/// <summary>
		/// Check whether or not the last mark made was a winning mark.
		/// </summary>
		/// <returns>True if a winning mark was made, otherwise false</returns>
		public Boolean CheckMoveForWin()
		{
			// Pre-determined set of winning combinations
			var winningTriplets = new int[][] {
				new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 },
				new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 },
				new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 }
			};

			// Check every winning combination against the board
			foreach (var winningTriplet in winningTriplets)
			{
				// Get the value of spaces
				Int32 a = board.GetSpaceValue(winningTriplet[0]),
					  b = board.GetSpaceValue(winningTriplet[1]),
					  c = board.GetSpaceValue(winningTriplet[2]);

				// If every space of the combination is the same
				// and those spaces aren't empty, we have a winner
				if (a == b && b == c && a != (int)Player.Empty)
					return true;
			}

			return false;
		}

		/// <summary>
		/// Check whether or not every space on the board has been marked.
		/// </summary>
		/// <returns>True if every space is marked, otherwise false</returns>
		public Boolean IsBoardFull() { return board.CountFreeSpaces() == 0 ? true : false; }

		/// <summary>
		/// Reset the Tic-Tac-Toe Board
		/// </summary>
		public void ResetBoard() { board.ClearBoard(); }

		private Char WhoMakesTheFirstMove() { return new Random(DateTime.Now.Millisecond).Next(6) < 3 ? 'X' : 'O'; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Engine
{
	public class Logic
	{
		private readonly Board Grid;
		public Char CurrentPlayer { get; private set; }

		public Logic()
		{
			Grid = new Board();
			CurrentPlayer = WhoMakesTheFirstMove();
		}

		public void SwitchPlayer()
		{
			CurrentPlayer = CurrentPlayer == 'X' ? 'O' : 'X';
		}

		public Boolean MarkBoardSpace(Space space)
		{
			return MarkBoardSpace(space.PositionX, space.PositionY);
		}

		public Boolean MarkBoardSpace(Int32 positionX, Int32 positionY)
		{
			// Check if board space is empty, if so mark
			// the space with the current player's mark.
			if (Grid.IsSpaceEmpty(positionX, positionY))
			{
				// Set the space
				Grid.SetSpaceValue(positionX, positionY, CurrentPlayer);
				return true;
			}

			return false;
		}

		public Boolean CheckMoveForWin()
		{
			var winningTriplets = new int[][] {
				new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 },
				new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 },
				new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 }
			};

			foreach (var winningTriplet in winningTriplets)
			{
				Int32 a = Grid.GetSpaceValue(winningTriplet[0]),
					  b = Grid.GetSpaceValue(winningTriplet[1]),
					  c = Grid.GetSpaceValue(winningTriplet[2]);

				// TODO: Enhance readiblity
				if (a == b && b == c && a != (int)Player.Empty)
				{
					return true;
				}
			}

			return false;
		}

		public Boolean IsBoardFull()
		{
			return Grid.CountFreeSpaces() == 0 ? true : false;
		}

		public void ResetBoard()
		{
			Grid.ClearBoard();
		}

		private Char WhoMakesTheFirstMove()
		{
			int randomNumber = new Random(DateTime.Now.Millisecond).Next(2);
			return randomNumber == 0 ? 'X' : 'O';
		}
	}
}

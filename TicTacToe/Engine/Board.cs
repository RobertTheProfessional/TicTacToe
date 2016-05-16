using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Engine
{
	public class Board
	{
		private Int32 grid = 0;

		public Board() { }

		/// <summary>
		/// Get the current bit state of a grid space by x,y coordinates.
		/// </summary>
		/// <param name="positionX">Row position of the space</param>
		/// <param name="positionY">Column position of the space</param>
		/// <returns>The current bit state of the space.</returns>
		public Int32 GetSpaceValue(Int32 positionX, Int32 positionY)
		{
			Int32 position = CalculateBitPosition(positionX, positionY);
			Int32 mask = GetMask(position);
			return (this.grid & mask) >> position;
		}

		/// <summary>
		/// Get the current bit state of a grid space by bit position.
		/// </summary>
		/// <param name="position">Bit position of the space</param>
		/// <returns>The current bit state of the space.</returns>
		public Int32 GetSpaceValue(Int32 position)
		{
			int x = position % 3;
			int y = position / 3;
			return GetSpaceValue(x, y);
		}
		
		/// <summary>
		/// Get the current owner of a grid space by x,y coordinates.
		/// </summary>
		/// <param name="positionX">Row position of the space</param>
		/// <param name="positionY">Column position of the space</param>
		/// <returns>The current owner of the space.</returns>
		public Char GetOwner(Int32 positionX, Int32 positionY) { return PlayerExtensions.GetKey(GetSpaceValue(positionX, positionY)); }

		/// <summary>
		/// Get the current owner of a grid space by bit position.
		/// </summary>
		/// <param name="position">Bit position of the space</param>
		/// <returns>The current owner of the space.</returns>
		public Char GetOwner(Int32 position) { return PlayerExtensions.GetKey(GetSpaceValue(position)); }

		/// <summary>
		/// Set the owner of a grid space by x,y coordinates. 
		/// </summary>
		/// <param name="positionX">Row position of the space</param>
		/// <param name="positionY">Column position of the space</param>
		/// <param name="owner">Owner to set the space to</param>
		public void SetSpaceValue(Int32 positionX, Int32 positionY, Char owner)
		{
			Int32 position = CalculateBitPosition(positionX, positionY);
			grid = (grid & ~GetMask(position)) | (PlayerExtensions.GetValue(owner) << position);
		}

		/// <summary>
		/// Set the owner of a grid space by the bit position.
		/// </summary>
		/// <param name="position">Bit position of the space</param>
		/// <param name="owner">Owner to set the space to</param>
		public void SetSpaceValue(Int32 position, Char owner)
		{
			int x = position % 3;
			int y = position / 3;
			SetSpaceValue(x, y, owner);
		}

		/// <summary>
		/// Get the binary representation of the grid.
		/// </summary>
		/// <returns>Grid in 18-bit representation</returns>
		public Int32 GetBoard() { return grid; }

		/// <summary>
		/// Get the array representation of the grid.
		/// </summary>
		/// <returns>Two-dimensional array of the grid</returns>
		public Char[,] Get2dBoard()
		{
			var arrayBoard = new Char[3, 3];

			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					arrayBoard[i, j] = PlayerExtensions.GetKey(GetSpaceValue(i, j));

			return arrayBoard;
		}

		/// <summary>
		/// Check if a grid space is unmarked.
		/// </summary>
		/// <param name="positionX">Row position of the space</param>
		/// <param name="positionY">Column position of the space</param>
		/// <returns>True if space is unmarked, otherwise false</returns>
		public Boolean IsSpaceEmpty(Int32 positionX, Int32 positionY)
		{
			return GetSpaceValue(positionX, positionY) == 0 ? true : false;
		}

		/// <summary>
		/// Check if a grid space is unmarked.
		/// </summary>
		/// <param name="position">Bit position of the space</param>
		/// <returns>True if space is unmarked, otherwise false</returns>
		public Boolean IsSpaceEmpty(Int32 position)
		{
			int x = position % 3;
			int y = position / 3;
			return IsSpaceEmpty(x, y);
		}

		/// <summary>
		/// Count the number of free spaces on the grid.
		/// </summary>
		/// <returns>Number of unmarked grid spaces</returns>
		public Int32 CountFreeSpaces()
		{
			int freeSpaces = 0;

			for (int i = 0; i < 9; i++)
				if (GetSpaceValue(i) == 0)
					freeSpaces += 1;

			return freeSpaces;
		}

		/// <summary>
		/// Unmark all the spaces on the board.
		/// </summary>
		public void ClearBoard()
		{
			grid = 0;
		}

		private Int32 GetMask(Int32 position) { return 3 << position; }
		private Int32 CalculateBitPosition(Int32 positionX, Int32 positionY) { return (positionX + positionY * 3) * 2; }
	}
}

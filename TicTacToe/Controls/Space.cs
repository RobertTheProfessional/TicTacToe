using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe.Controls
{
	public class Space : Button
	{
		private Char owner;

		/// <summary>
		/// Owner of this Space
		/// </summary>
		public Char Owner {
			get
			{
				return owner;
			}
			set
			{
				if (owner != value)
				{
					// Set the owner of this space
					owner = value;

					// Change the text of this space's control
					this.Text = owner == 'E' ? "" : value.ToString();

					// Diasble the ability to click this space
					this.Enabled = owner == 'E' ? true : false;
					
				}
			}
		}

		/// <summary>
		/// Row coordinate on the grid.
		/// </summary>
		public Int32 PositionX { get; set; }

		/// <summary>
		/// Column coordinate of the grid.
		/// </summary>
		public Int32 PositionY { get; set; }
	}
}

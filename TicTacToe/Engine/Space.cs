using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe.Engine
{
	public class Space : Button
	{
		private Char owner;

		public Char Owner {
			get
			{
				return owner;
			}
			set
			{
				if (owner != value)
				{
					owner = value;

					this.Text = owner == 'E' ? "" : value.ToString();
				}
			}
		}

		public Int32 PositionX { get; set; }

		public Int32 PositionY { get; set; }
	}
}

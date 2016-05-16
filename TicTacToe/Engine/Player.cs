using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Engine
{
	public enum Player: Int32
	{
		Empty = 0,
		X = 1,
		O = 2
	}

	public static class PlayerExtensions
	{
		public static Char GetKey(Int32 value)
		{
			return Enum.GetName(typeof(Player), value).ToCharArray()[0];
		}

		public static Int32 GetValue(Char owner)
		{
			switch (owner)
			{
				case 'E': return (Int32)Player.Empty;
				case 'X': return (Int32)Player.X;
				case 'O': return (Int32)Player.O;
				default: return -1;
			}
		}
	}
}

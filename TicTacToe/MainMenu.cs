using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class MainMenu : Form
	{
		private Game game = null;

		public MainMenu()
		{
			InitializeComponent();
		}

		private void StartSoloGameBtn_Click(object sender, EventArgs e)
		{
			// Create a new game
			game = new Game(this);

			// Hide the main menu
			this.Hide();

			// Show the new game
			game.Show();
		}
	}
}

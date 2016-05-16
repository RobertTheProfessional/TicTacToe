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
		private TwoPlayerTestGame game = null;

		public MainMenu()
		{
			InitializeComponent();

			// If environment is debug,
			// show debug options
			#if DEBUG
			this.StartTestGameBtn.Enabled = true;
			this.StartTestGameBtn.Visible = true;
			#endif
		}

		private void StartTestGameBtn_Click(object sender, EventArgs e)
		{
			// Create a new game
			game = new TwoPlayerTestGame(this);

			// Hide the main menu
			this.Hide();

			// Show the new game
			game.Show();
		}
	}
}

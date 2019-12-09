using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipProject
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        //trzy stany, Menu-opcja ustawienia planszy, Game - plansza, stan pusty
        public void setControls(String state)
        {
            if (state.Equals("Menu"))
            {
                this.Size = new Size(410, 200);
                gbSettings.Enabled = true;
                lvBoard.Visible = false;

            }
            else if (state.Equals("Game"))
            {
                this.Size = new Size(500, 500);
                gbSettings.Enabled = false;
                lvBoard.Visible = true;
            }
            else
            {

            }
        }

        public void createCompletionList(int x, int y)
        {
            //uzupeł
            for (int i = 0; i < x + 1; i++)
            {
                lvBoard.Columns.Add(i.ToString(), 20, HorizontalAlignment.Left);
            }


            string[] signs = new string[x];
            for (int j = 1; j < y+1; j++)
            {
                signs[0] = j.ToString();
                for (int k = 1; k < x; k++)
                {
                    signs[k] = "?";
                }
                ListViewItem lvi = new ListViewItem(signs);
                lvBoard.Items.Add(lvi);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lvBoard.View = View.Details;
            setControls("Game");
            Board board = new Board(Convert.ToInt32(nrPozX.Value), Convert.ToInt32(nrPozY.Value));
            createCompletionList(Convert.ToInt32(nrPozX.Value), Convert.ToInt32(nrPozY.Value));

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            setControls("Menu");
        }

        private void lvBoard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

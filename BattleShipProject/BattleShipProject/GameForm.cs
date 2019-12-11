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
                btnRestart.Visible = false;
            }
            else if (state.Equals("Game"))
            {
                this.Size = new Size(650, 500);
                gbSettings.Enabled = false;
                lvBoard.Visible = true;
                btnRestart.Visible = true;
            }
            else
            {

            }
        }

        public void createCompletionList(int x, int y)
        {
            //uzupełnienie listy
            for (int i = 0; i < x; i++)
            {
                lvBoard.Columns.Add("", 20, HorizontalAlignment.Left);
            }

            string[] signs = new string[x];
            for (int j = 0; j < y ; j++)
            {
                for (int k = 0; k < x ; k++)
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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            setControls("Menu");
            lvBoard.Clear();
        }


        private void lvBoard_MouseDown(object sender, MouseEventArgs e)
        {
            var info = lvBoard.HitTest(e.X, e.Y);
            try
            {
                var row = info.Item.Index;
                var col = info.Item.SubItems.IndexOf(info.SubItem);
               // var value = info.Item.SubItems[col].Text;
                lvBoard.Items[row].SubItems[col].Text = "X";
                lvBoard.Items[row].UseItemStyleForSubItems = false;
                lvBoard.Items[row].SubItems[col].ForeColor = Color.Red;
                //MessageBox.Show(string.Format("{0}:{1}", row, col, value));
            } catch
            {
                //Wczytanie wartości z poza listy
            }

        }
    }
}

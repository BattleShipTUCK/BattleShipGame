using System;
using System.Collections;
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
        private int hitShot = 0;
        private int missedShot = 0;

        private Board board { get; set; }

        public GameForm()
        {
            InitializeComponent();
        }
        public void setControls(String state)
        {
            if (state.Equals("Menu"))
            {
                this.Size = new Size(410, 200);
                gbSettings.Enabled = true;
                lvBoard.Visible = false;
                btnRestart.Visible = false;
                hitShot = 0;
                missedShot = 0;
                lvBoard.Enabled = true;
            }
            else if (state.Equals("Game"))
            {
                this.Size = new Size(450, 400);
                gbSettings.Enabled = false;
                lvBoard.Visible = true;
                btnRestart.Visible = true;
                hitShot = 0;
                missedShot = 0;
                lvBoard.Enabled = true;
            }
            else if (state.Equals("GameOver"))
            {
                this.Size = new Size(450, 400);
                gbSettings.Enabled = false;
                lvBoard.Visible = true;
                btnRestart.Visible = true;
                lvBoard.Enabled = false;
            }
        }

        public void createCompletionList()
        {
            List<string> boardListViewItem = board.InitializeBoard();
            for (int i = 0; i < board.getboardSizeX(); i++)
            {
                lvBoard.Columns.Add("", 30, HorizontalAlignment.Left);
            }
            DrawBoard(boardListViewItem);

        }

        private void DrawBoard(List<string> boardListViewItem)
        {
            int idx = 0;
            for (int i = 0; i < board.getboardSizeY(); i++)
            {
                List<String> itemsInRow = boardListViewItem.GetRange(idx, board.getboardSizeX());
                string[] itemsInRoww = itemsInRow.ToArray();
                var listViewItem = new ListViewItem(itemsInRoww);
                lvBoard.Items.Add(listViewItem);
                idx += board.getboardSizeX() - 1;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lvBoard.View = View.Details;
            setControls("Game");

            board = new Board(Convert.ToInt32(nrPozX.Value), Convert.ToInt32(nrPozY.Value), (int)nrShip1.Value, (int)nrShip2.Value, (int)nrShip3.Value, (int)nrShip4.Value);

            createCompletionList();
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
                int row = info.Item.Index;
                int col = info.Item.SubItems.IndexOf(info.SubItem);

                string shotResult = board.VerifyShot(row, col);
                if (lvBoard.Items[row].SubItems[col].Text.Equals("?"))
                {
                    ShotStats(shotResult);
                }
                    
                lvBoard.Items[row].SubItems[col].Text = shotResult;
                lvBoard.Items[row].UseItemStyleForSubItems = false;
                lvBoard.Items[row].SubItems[col].ForeColor = (shotResult == "X") ? Color.Red : Color.Green;

                if (CheckWin())
                {
                    setControls("GameOver"); 
                    MessageBox.Show("Wszystkie statki zostały zestrzelone.Strzały udane : " + hitShot + ", strzały chybione : " + missedShot);
                }
            }
            catch
            {
                //Wczytanie wartości z poza listy
                MessageBox.Show("Wybrano nieprawidłowe pole");
            }

        }

        private  bool CheckWin()
        {
            if ((missedShot + hitShot) > 24)
                return true;
            else
                return false;
        }

        private  void ShotStats(String strzal)
        {
            if (strzal.Equals("X")) {
                missedShot += 1;
            } else
            {
                hitShot += 1;
            }
        }

    }
}

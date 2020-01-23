using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace BattleShipProject
{
    public partial class GameForm : Form
    {
        readonly Stats stats = new Stats();
        readonly int win = 10;
        private Board Board { get; set; }
        public GameForm()
        {
            InitializeComponent();
        }
        public void SetControls(String state)
        {
            if (state != null)
            {
                if (state.Equals("Menu", StringComparison.CurrentCulture))
                {
                    this.Size = new Size(410, 200);
                    gbSettings.Enabled = true;
                    lvBoard.Visible = false;
                    btnRestart.Visible = false;
                    stats.SetHitShot(0);
                    stats.SetMissedShot(0);
                    lvBoard.Enabled = true;
                }
                //else if (state.Equals("Game"))
                else if (state.Equals("Game", StringComparison.CurrentCulture))

                {
                    this.Size = new Size(450, 400);
                    gbSettings.Enabled = false;
                    lvBoard.Visible = true;
                    btnRestart.Visible = true;
                    stats.SetHitShot(0);
                    stats.SetMissedShot(0);
                    lvBoard.Enabled = true;
                }
                else if (state.Equals("GameOver", StringComparison.CurrentCulture))
                {
                    this.Size = new Size(450, 400);
                    gbSettings.Enabled = false;
                    lvBoard.Visible = true;
                    btnRestart.Visible = true;
                    lvBoard.Enabled = false;
                }
            }
        }

        public void CreateCompletionList()
        {
            List<string> boardListViewItem = Board.InitializeBoard();
            for (int i = 0; i < Board.getboardSizeX(); i++)
            {
                lvBoard.Columns.Add("", 30, HorizontalAlignment.Left);
            }
            DrawBoard(boardListViewItem);
        }

        private void DrawBoard(List<string> boardListViewItem)
        {
            int idx = 0;
            for (int i = 0; i < Board.getboardSizeY(); i++)
            {
                List<String> itemsInRow = boardListViewItem.GetRange(idx, Board.getboardSizeX());
                string[] itemsInRoww = itemsInRow.ToArray();
                var listViewItem = new ListViewItem(itemsInRoww);
                lvBoard.Items.Add(listViewItem);
                idx += Board.getboardSizeX() - 1;
            }
        }



        private void GameForm_Load(object sender, EventArgs e)
        {
            SetControls("Menu");
        }


        private void BtnRestart_Click(object sender, EventArgs e)
        {
            SetControls("Menu");
            lvBoard.Clear();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            lvBoard.View = View.Details;
            SetControls("Game");
            Board = new Board(Convert.ToInt32(nrPozX.Value), Convert.ToInt32(nrPozY.Value));
            CreateCompletionList();
        }

        private void LvBoard_MouseDown(object sender, MouseEventArgs e)
        {
            var info = lvBoard.HitTest(e.X, e.Y);
            try
            {
                int row = info.Item.Index;
                int col = info.Item.SubItems.IndexOf(info.SubItem);

                string shotResult = Board.VerifyShot(row, col);
                if (lvBoard.Items[row].SubItems[col].Text.Equals("?", StringComparison.CurrentCulture))
                {
                    stats.ShotStats(shotResult);
                }

                lvBoard.Items[row].SubItems[col].Text = shotResult;
                lvBoard.Items[row].UseItemStyleForSubItems = false;
                lvBoard.Items[row].SubItems[col].ForeColor = (shotResult == "X") ? Color.Red : Color.Green;

                if (stats.CheckWin(win))
                {
                    SetControls("GameOver");
                    MessageBox.Show("Wszystkie statki zostały zestrzelone.Strzały udane : " + Convert.ToString(stats.GetHitShot(), CultureInfo.CurrentCulture) + ", strzały chybione : " + Convert.ToString(stats.GetMissedShot(), CultureInfo.CurrentCulture));
                }
            }
            catch (Exception ex)
            {
                //info = rm.GetString("nieprawidlowePole");

                MessageBox.Show("Wybrano nieprawidłowe pole " +  ex.Message);
            }
        }
    }
}

namespace BattleShipProject
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.lvBoard = new System.Windows.Forms.ListView();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.nrPozY = new System.Windows.Forms.NumericUpDown();
            this.nrPozX = new System.Windows.Forms.NumericUpDown();
            this.lblship1 = new System.Windows.Forms.Label();
            this.lblship2 = new System.Windows.Forms.Label();
            this.nrShip2 = new System.Windows.Forms.NumericUpDown();
            this.nrShip1 = new System.Windows.Forms.NumericUpDown();
            this.lblship3 = new System.Windows.Forms.Label();
            this.lblship4 = new System.Windows.Forms.Label();
            this.nrShip4 = new System.Windows.Forms.NumericUpDown();
            this.nrShip3 = new System.Windows.Forms.NumericUpDown();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPozY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPozX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.Location = new System.Drawing.Point(169, 89);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 37);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.nrPozY);
            this.gbSettings.Controls.Add(this.nrPozX);
            this.gbSettings.Controls.Add(this.btnStart);
            this.gbSettings.Controls.Add(this.nrShip4);
            this.gbSettings.Controls.Add(this.nrShip3);
            this.gbSettings.Controls.Add(this.nrShip2);
            this.gbSettings.Controls.Add(this.nrShip1);
            this.gbSettings.Controls.Add(this.lblship4);
            this.gbSettings.Controls.Add(this.lblship3);
            this.gbSettings.Controls.Add(this.lblship2);
            this.gbSettings.Controls.Add(this.lblship1);
            this.gbSettings.Controls.Add(this.lblY);
            this.gbSettings.Controls.Add(this.lblX);
            this.gbSettings.Controls.Add(this.lblSize);
            this.gbSettings.Location = new System.Drawing.Point(16, 7);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(4);
            this.gbSettings.Size = new System.Drawing.Size(468, 133);
            this.gbSettings.TabIndex = 20;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // lvBoard
            // 
            this.lvBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvBoard.GridLines = true;
            this.lvBoard.HideSelection = false;
            this.lvBoard.Location = new System.Drawing.Point(13, 161);
            this.lvBoard.Margin = new System.Windows.Forms.Padding(4);
            this.lvBoard.Name = "lvBoard";
            this.lvBoard.Size = new System.Drawing.Size(471, 181);
            this.lvBoard.TabIndex = 21;
            this.lvBoard.UseCompatibleStateImageBehavior = false;
            this.lvBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvBoard_MouseDown);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestart.Location = new System.Drawing.Point(185, 372);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(123, 37);
            this.btnRestart.TabIndex = 22;
            this.btnRestart.Text = "Restart game";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 48);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(79, 17);
            this.lblSize.TabIndex = 20;
            this.lblSize.Text = "Board size:";
            // 
            // lblX
            // 
            this.lblX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(84, 20);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 17);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "X:";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblY
            // 
            this.lblY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(84, 57);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 17);
            this.lblY.TabIndex = 22;
            this.lblY.Text = "Y:";
            // 
            // nrPozY
            // 
            this.nrPozY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrPozY.Enabled = false;
            this.nrPozY.Location = new System.Drawing.Point(114, 51);
            this.nrPozY.Margin = new System.Windows.Forms.Padding(4);
            this.nrPozY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrPozY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrPozY.Name = "nrPozY";
            this.nrPozY.Size = new System.Drawing.Size(56, 22);
            this.nrPozY.TabIndex = 32;
            this.nrPozY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nrPozX
            // 
            this.nrPozX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrPozX.Enabled = false;
            this.nrPozX.Location = new System.Drawing.Point(115, 16);
            this.nrPozX.Margin = new System.Windows.Forms.Padding(4);
            this.nrPozX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrPozX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrPozX.Name = "nrPozX";
            this.nrPozX.Size = new System.Drawing.Size(55, 22);
            this.nrPozX.TabIndex = 31;
            this.nrPozX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblship1
            // 
            this.lblship1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblship1.AutoSize = true;
            this.lblship1.Location = new System.Drawing.Point(190, 19);
            this.lblship1.Name = "lblship1";
            this.lblship1.Size = new System.Drawing.Size(52, 17);
            this.lblship1.TabIndex = 23;
            this.lblship1.Text = "Ship 1:";
            // 
            // lblship2
            // 
            this.lblship2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblship2.AutoSize = true;
            this.lblship2.Location = new System.Drawing.Point(188, 55);
            this.lblship2.Name = "lblship2";
            this.lblship2.Size = new System.Drawing.Size(52, 17);
            this.lblship2.TabIndex = 24;
            this.lblship2.Text = "Ship 2:";
            // 
            // nrShip2
            // 
            this.nrShip2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrShip2.Enabled = false;
            this.nrShip2.Location = new System.Drawing.Point(252, 48);
            this.nrShip2.Margin = new System.Windows.Forms.Padding(4);
            this.nrShip2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrShip2.Name = "nrShip2";
            this.nrShip2.Size = new System.Drawing.Size(56, 22);
            this.nrShip2.TabIndex = 28;
            this.nrShip2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nrShip1
            // 
            this.nrShip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrShip1.Enabled = false;
            this.nrShip1.Location = new System.Drawing.Point(252, 16);
            this.nrShip1.Margin = new System.Windows.Forms.Padding(4);
            this.nrShip1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrShip1.Name = "nrShip1";
            this.nrShip1.Size = new System.Drawing.Size(56, 22);
            this.nrShip1.TabIndex = 27;
            this.nrShip1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblship3
            // 
            this.lblship3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblship3.AutoSize = true;
            this.lblship3.Location = new System.Drawing.Point(318, 23);
            this.lblship3.Name = "lblship3";
            this.lblship3.Size = new System.Drawing.Size(52, 17);
            this.lblship3.TabIndex = 25;
            this.lblship3.Text = "Ship 3:";
            // 
            // lblship4
            // 
            this.lblship4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblship4.AutoSize = true;
            this.lblship4.Location = new System.Drawing.Point(315, 59);
            this.lblship4.Name = "lblship4";
            this.lblship4.Size = new System.Drawing.Size(52, 17);
            this.lblship4.TabIndex = 26;
            this.lblship4.Text = "Ship 4:";
            // 
            // nrShip4
            // 
            this.nrShip4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrShip4.Enabled = false;
            this.nrShip4.Location = new System.Drawing.Point(383, 55);
            this.nrShip4.Margin = new System.Windows.Forms.Padding(4);
            this.nrShip4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrShip4.Name = "nrShip4";
            this.nrShip4.Size = new System.Drawing.Size(55, 22);
            this.nrShip4.TabIndex = 30;
            this.nrShip4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nrShip3
            // 
            this.nrShip3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrShip3.Enabled = false;
            this.nrShip3.Location = new System.Drawing.Point(382, 14);
            this.nrShip3.Margin = new System.Windows.Forms.Padding(4);
            this.nrShip3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrShip3.Name = "nrShip3";
            this.nrShip3.Size = new System.Drawing.Size(56, 22);
            this.nrShip3.TabIndex = 29;
            this.nrShip3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lvBoard);
            this.Controls.Add(this.gbSettings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "Battleship ";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPozY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPozX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.ListView lvBoard;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.NumericUpDown nrPozY;
        private System.Windows.Forms.NumericUpDown nrPozX;
        private System.Windows.Forms.NumericUpDown nrShip4;
        private System.Windows.Forms.NumericUpDown nrShip3;
        private System.Windows.Forms.NumericUpDown nrShip2;
        private System.Windows.Forms.NumericUpDown nrShip1;
        private System.Windows.Forms.Label lblship4;
        private System.Windows.Forms.Label lblship3;
        private System.Windows.Forms.Label lblship2;
        private System.Windows.Forms.Label lblship1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblSize;
    }
}
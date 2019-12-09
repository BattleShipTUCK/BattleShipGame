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
            this.nrPozY = new System.Windows.Forms.NumericUpDown();
            this.nrPozX = new System.Windows.Forms.NumericUpDown();
            this.nrShip4 = new System.Windows.Forms.NumericUpDown();
            this.nrShip3 = new System.Windows.Forms.NumericUpDown();
            this.nrShip2 = new System.Windows.Forms.NumericUpDown();
            this.nrShip1 = new System.Windows.Forms.NumericUpDown();
            this.lblship4 = new System.Windows.Forms.Label();
            this.lblship3 = new System.Windows.Forms.Label();
            this.lblship2 = new System.Windows.Forms.Label();
            this.lblship1 = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lvBoard = new System.Windows.Forms.ListView();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPozY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPozX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.Location = new System.Drawing.Point(171, 72);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 30);
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
            this.gbSettings.Location = new System.Drawing.Point(12, 6);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(440, 108);
            this.gbSettings.TabIndex = 20;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // nrPozY
            // 
            this.nrPozY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrPozY.Location = new System.Drawing.Point(134, 47);
            this.nrPozY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nrPozY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrPozY.Name = "nrPozY";
            this.nrPozY.Size = new System.Drawing.Size(42, 20);
            this.nrPozY.TabIndex = 32;
            this.nrPozY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nrPozX
            // 
            this.nrPozX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrPozX.Location = new System.Drawing.Point(135, 19);
            this.nrPozX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nrPozX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrPozX.Name = "nrPozX";
            this.nrPozX.Size = new System.Drawing.Size(41, 20);
            this.nrPozX.TabIndex = 31;
            this.nrPozX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nrShip4
            // 
            this.nrShip4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrShip4.Location = new System.Drawing.Point(336, 50);
            this.nrShip4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrShip4.Name = "nrShip4";
            this.nrShip4.Size = new System.Drawing.Size(41, 20);
            this.nrShip4.TabIndex = 30;
            // 
            // nrShip3
            // 
            this.nrShip3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrShip3.Location = new System.Drawing.Point(335, 17);
            this.nrShip3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrShip3.Name = "nrShip3";
            this.nrShip3.Size = new System.Drawing.Size(42, 20);
            this.nrShip3.TabIndex = 29;
            // 
            // nrShip2
            // 
            this.nrShip2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrShip2.Location = new System.Drawing.Point(238, 45);
            this.nrShip2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrShip2.Name = "nrShip2";
            this.nrShip2.Size = new System.Drawing.Size(42, 20);
            this.nrShip2.TabIndex = 28;
            // 
            // nrShip1
            // 
            this.nrShip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrShip1.Location = new System.Drawing.Point(238, 19);
            this.nrShip1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrShip1.Name = "nrShip1";
            this.nrShip1.Size = new System.Drawing.Size(42, 20);
            this.nrShip1.TabIndex = 27;
            // 
            // lblship4
            // 
            this.lblship4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblship4.AutoSize = true;
            this.lblship4.Location = new System.Drawing.Point(285, 54);
            this.lblship4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblship4.Name = "lblship4";
            this.lblship4.Size = new System.Drawing.Size(40, 13);
            this.lblship4.TabIndex = 26;
            this.lblship4.Text = "Ship 4:";
            // 
            // lblship3
            // 
            this.lblship3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblship3.AutoSize = true;
            this.lblship3.Location = new System.Drawing.Point(287, 24);
            this.lblship3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblship3.Name = "lblship3";
            this.lblship3.Size = new System.Drawing.Size(40, 13);
            this.lblship3.TabIndex = 25;
            this.lblship3.Text = "Ship 3:";
            // 
            // lblship2
            // 
            this.lblship2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblship2.AutoSize = true;
            this.lblship2.Location = new System.Drawing.Point(190, 50);
            this.lblship2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblship2.Name = "lblship2";
            this.lblship2.Size = new System.Drawing.Size(40, 13);
            this.lblship2.TabIndex = 24;
            this.lblship2.Text = "Ship 2:";
            // 
            // lblship1
            // 
            this.lblship1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblship1.AutoSize = true;
            this.lblship1.Location = new System.Drawing.Point(191, 21);
            this.lblship1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblship1.Name = "lblship1";
            this.lblship1.Size = new System.Drawing.Size(40, 13);
            this.lblship1.TabIndex = 23;
            this.lblship1.Text = "Ship 1:";
            // 
            // lblY
            // 
            this.lblY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(112, 52);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 22;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(112, 22);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "X:";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(49, 39);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(59, 13);
            this.lblSize.TabIndex = 20;
            this.lblSize.Text = "Board size:";
            // 
            // lvBoard
            // 
            this.lvBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvBoard.HideSelection = false;
            this.lvBoard.Location = new System.Drawing.Point(12, 130);
            this.lvBoard.Name = "lvBoard";
            this.lvBoard.Size = new System.Drawing.Size(440, 196);
            this.lvBoard.TabIndex = 21;
            this.lvBoard.UseCompatibleStateImageBehavior = false;
            this.lvBoard.SelectedIndexChanged += new System.EventHandler(this.lvBoard_SelectedIndexChanged);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 338);
            this.Controls.Add(this.lvBoard);
            this.Controls.Add(this.gbSettings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "Battleship ";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPozY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrPozX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrShip1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbSettings;
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
        private System.Windows.Forms.ListView lvBoard;
    }
}
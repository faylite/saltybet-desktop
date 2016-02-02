namespace SaltyBet_Desktop
{
	partial class MainWindow
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
			System.Windows.Forms.Panel pInfo;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.tbBetStatus = new System.Windows.Forms.TextBox();
			this.lbBetStatus = new System.Windows.Forms.Label();
			this.tbSaltBalance = new System.Windows.Forms.TextBox();
			this.lbSaltBalance = new System.Windows.Forms.Label();
			this.pMain = new System.Windows.Forms.Panel();
			this.pBlue = new System.Windows.Forms.Panel();
			this.tbBlueOdds = new System.Windows.Forms.TextBox();
			this.tbBluePot = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbBlueName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pRed = new System.Windows.Forms.Panel();
			this.tbRedOdds = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbRedPot = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbRedName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgwMatchHistory = new System.Windows.Forms.DataGridView();
			this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RedPot = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RedOdds = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BlueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BluePot = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BlueOdds = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Winner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			pInfo = new System.Windows.Forms.Panel();
			pInfo.SuspendLayout();
			this.pMain.SuspendLayout();
			this.pBlue.SuspendLayout();
			this.pRed.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwMatchHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// pInfo
			// 
			pInfo.BackColor = System.Drawing.Color.Transparent;
			pInfo.Controls.Add(this.tbBetStatus);
			pInfo.Controls.Add(this.lbBetStatus);
			pInfo.Controls.Add(this.tbSaltBalance);
			pInfo.Controls.Add(this.lbSaltBalance);
			pInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			pInfo.Location = new System.Drawing.Point(373, 0);
			pInfo.Name = "pInfo";
			pInfo.Size = new System.Drawing.Size(505, 350);
			pInfo.TabIndex = 5;
			// 
			// tbBetStatus
			// 
			this.tbBetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBetStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbBetStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbBetStatus.Enabled = false;
			this.tbBetStatus.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBetStatus.Location = new System.Drawing.Point(6, 125);
			this.tbBetStatus.Name = "tbBetStatus";
			this.tbBetStatus.ReadOnly = true;
			this.tbBetStatus.Size = new System.Drawing.Size(493, 34);
			this.tbBetStatus.TabIndex = 17;
			this.tbBetStatus.Text = "0";
			this.tbBetStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbBetStatus
			// 
			this.lbBetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lbBetStatus.AutoSize = true;
			this.lbBetStatus.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBetStatus.Location = new System.Drawing.Point(194, 91);
			this.lbBetStatus.Name = "lbBetStatus";
			this.lbBetStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbBetStatus.Size = new System.Drawing.Size(117, 26);
			this.lbBetStatus.TabIndex = 16;
			this.lbBetStatus.Text = "Bet Status";
			this.lbBetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbSaltBalance
			// 
			this.tbSaltBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSaltBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbSaltBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSaltBalance.Enabled = false;
			this.tbSaltBalance.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSaltBalance.Location = new System.Drawing.Point(6, 38);
			this.tbSaltBalance.Name = "tbSaltBalance";
			this.tbSaltBalance.ReadOnly = true;
			this.tbSaltBalance.Size = new System.Drawing.Size(493, 34);
			this.tbSaltBalance.TabIndex = 15;
			this.tbSaltBalance.Text = "0";
			this.tbSaltBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbSaltBalance
			// 
			this.lbSaltBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lbSaltBalance.AutoSize = true;
			this.lbSaltBalance.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSaltBalance.Location = new System.Drawing.Point(184, 9);
			this.lbSaltBalance.Name = "lbSaltBalance";
			this.lbSaltBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbSaltBalance.Size = new System.Drawing.Size(136, 26);
			this.lbSaltBalance.TabIndex = 14;
			this.lbSaltBalance.Text = "Salt Balance";
			this.lbSaltBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(pInfo);
			this.pMain.Controls.Add(this.pBlue);
			this.pMain.Controls.Add(this.pRed);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1251, 350);
			this.pMain.TabIndex = 1;
			// 
			// pBlue
			// 
			this.pBlue.BackColor = System.Drawing.Color.SteelBlue;
			this.pBlue.Controls.Add(this.tbBlueOdds);
			this.pBlue.Controls.Add(this.tbBluePot);
			this.pBlue.Controls.Add(this.label5);
			this.pBlue.Controls.Add(this.label4);
			this.pBlue.Controls.Add(this.tbBlueName);
			this.pBlue.Controls.Add(this.label2);
			this.pBlue.Dock = System.Windows.Forms.DockStyle.Right;
			this.pBlue.Location = new System.Drawing.Point(878, 0);
			this.pBlue.Name = "pBlue";
			this.pBlue.Size = new System.Drawing.Size(373, 350);
			this.pBlue.TabIndex = 4;
			// 
			// tbBlueOdds
			// 
			this.tbBlueOdds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBlueOdds.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbBlueOdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbBlueOdds.Enabled = false;
			this.tbBlueOdds.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBlueOdds.Location = new System.Drawing.Point(12, 206);
			this.tbBlueOdds.Name = "tbBlueOdds";
			this.tbBlueOdds.ReadOnly = true;
			this.tbBlueOdds.Size = new System.Drawing.Size(348, 34);
			this.tbBlueOdds.TabIndex = 13;
			this.tbBlueOdds.Text = "0";
			this.tbBlueOdds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbBluePot
			// 
			this.tbBluePot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBluePot.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbBluePot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbBluePot.Enabled = false;
			this.tbBluePot.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBluePot.Location = new System.Drawing.Point(12, 125);
			this.tbBluePot.Name = "tbBluePot";
			this.tbBluePot.ReadOnly = true;
			this.tbBluePot.Size = new System.Drawing.Size(348, 34);
			this.tbBluePot.TabIndex = 11;
			this.tbBluePot.Text = "0";
			this.tbBluePot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(153, 171);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(64, 26);
			this.label5.TabIndex = 12;
			this.label5.Text = "Odds";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(163, 91);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(44, 26);
			this.label4.TabIndex = 10;
			this.label4.Text = "Pot";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbBlueName
			// 
			this.tbBlueName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBlueName.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbBlueName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbBlueName.Enabled = false;
			this.tbBlueName.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBlueName.Location = new System.Drawing.Point(12, 38);
			this.tbBlueName.Name = "tbBlueName";
			this.tbBlueName.ReadOnly = true;
			this.tbBlueName.Size = new System.Drawing.Size(348, 34);
			this.tbBlueName.TabIndex = 9;
			this.tbBlueName.Text = "0";
			this.tbBlueName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(96, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 26);
			this.label2.TabIndex = 8;
			this.label2.Text = "Character Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pRed
			// 
			this.pRed.BackColor = System.Drawing.Color.Crimson;
			this.pRed.Controls.Add(this.tbRedOdds);
			this.pRed.Controls.Add(this.label6);
			this.pRed.Controls.Add(this.tbRedPot);
			this.pRed.Controls.Add(this.label3);
			this.pRed.Controls.Add(this.tbRedName);
			this.pRed.Controls.Add(this.label1);
			this.pRed.Dock = System.Windows.Forms.DockStyle.Left;
			this.pRed.Location = new System.Drawing.Point(0, 0);
			this.pRed.Name = "pRed";
			this.pRed.Size = new System.Drawing.Size(373, 350);
			this.pRed.TabIndex = 3;
			// 
			// tbRedOdds
			// 
			this.tbRedOdds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRedOdds.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbRedOdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbRedOdds.Enabled = false;
			this.tbRedOdds.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRedOdds.Location = new System.Drawing.Point(12, 206);
			this.tbRedOdds.Name = "tbRedOdds";
			this.tbRedOdds.ReadOnly = true;
			this.tbRedOdds.Size = new System.Drawing.Size(348, 34);
			this.tbRedOdds.TabIndex = 15;
			this.tbRedOdds.Text = "0";
			this.tbRedOdds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(153, 171);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(64, 26);
			this.label6.TabIndex = 14;
			this.label6.Text = "Odds";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbRedPot
			// 
			this.tbRedPot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRedPot.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbRedPot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbRedPot.Enabled = false;
			this.tbRedPot.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRedPot.Location = new System.Drawing.Point(12, 125);
			this.tbRedPot.Name = "tbRedPot";
			this.tbRedPot.ReadOnly = true;
			this.tbRedPot.Size = new System.Drawing.Size(348, 34);
			this.tbRedPot.TabIndex = 13;
			this.tbRedPot.Text = "0";
			this.tbRedPot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(163, 91);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(44, 26);
			this.label3.TabIndex = 12;
			this.label3.Text = "Pot";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbRedName
			// 
			this.tbRedName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRedName.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbRedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbRedName.Enabled = false;
			this.tbRedName.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRedName.Location = new System.Drawing.Point(12, 38);
			this.tbRedName.Name = "tbRedName";
			this.tbRedName.ReadOnly = true;
			this.tbRedName.Size = new System.Drawing.Size(348, 34);
			this.tbRedName.TabIndex = 11;
			this.tbRedName.Text = "0";
			this.tbRedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(96, 9);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(179, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "Character Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgwMatchHistory
			// 
			this.dgwMatchHistory.AllowUserToAddRows = false;
			this.dgwMatchHistory.AllowUserToDeleteRows = false;
			this.dgwMatchHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwMatchHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgwMatchHistory.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgwMatchHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgwMatchHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgwMatchHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwMatchHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgwMatchHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwMatchHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Timestamp,
            this.RedName,
            this.RedPot,
            this.RedOdds,
            this.BlueName,
            this.BluePot,
            this.BlueOdds,
            this.Winner,
            this.MatchTime});
			this.dgwMatchHistory.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwMatchHistory.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgwMatchHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgwMatchHistory.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dgwMatchHistory.Location = new System.Drawing.Point(0, 350);
			this.dgwMatchHistory.Name = "dgwMatchHistory";
			this.dgwMatchHistory.ReadOnly = true;
			this.dgwMatchHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwMatchHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgwMatchHistory.Size = new System.Drawing.Size(1251, 196);
			this.dgwMatchHistory.TabIndex = 3;
			// 
			// Timestamp
			// 
			this.Timestamp.HeaderText = "Time Stamp";
			this.Timestamp.Name = "Timestamp";
			this.Timestamp.ReadOnly = true;
			// 
			// RedName
			// 
			this.RedName.HeaderText = "Red Name";
			this.RedName.Name = "RedName";
			this.RedName.ReadOnly = true;
			// 
			// RedPot
			// 
			this.RedPot.HeaderText = "Red Pot";
			this.RedPot.Name = "RedPot";
			this.RedPot.ReadOnly = true;
			// 
			// RedOdds
			// 
			this.RedOdds.HeaderText = "Red Odds";
			this.RedOdds.Name = "RedOdds";
			this.RedOdds.ReadOnly = true;
			// 
			// BlueName
			// 
			this.BlueName.HeaderText = "Blue Name";
			this.BlueName.Name = "BlueName";
			this.BlueName.ReadOnly = true;
			// 
			// BluePot
			// 
			this.BluePot.HeaderText = "Blue Pot";
			this.BluePot.Name = "BluePot";
			this.BluePot.ReadOnly = true;
			// 
			// BlueOdds
			// 
			this.BlueOdds.HeaderText = "Blue Odds";
			this.BlueOdds.Name = "BlueOdds";
			this.BlueOdds.ReadOnly = true;
			// 
			// Winner
			// 
			this.Winner.HeaderText = "Winner";
			this.Winner.Name = "Winner";
			this.Winner.ReadOnly = true;
			// 
			// MatchTime
			// 
			this.MatchTime.HeaderText = "Match Time";
			this.MatchTime.Name = "MatchTime";
			this.MatchTime.ReadOnly = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Ivory;
			this.ClientSize = new System.Drawing.Size(1251, 546);
			this.Controls.Add(this.dgwMatchHistory);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.Text = "SaltyBot";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			pInfo.ResumeLayout(false);
			pInfo.PerformLayout();
			this.pMain.ResumeLayout(false);
			this.pBlue.ResumeLayout(false);
			this.pBlue.PerformLayout();
			this.pRed.ResumeLayout(false);
			this.pRed.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwMatchHistory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbRedName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbRedPot;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbRedOdds;
		private System.Windows.Forms.Panel pRed;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbBlueName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbBluePot;
		private System.Windows.Forms.TextBox tbBlueOdds;
		private System.Windows.Forms.Panel pBlue;
		private System.Windows.Forms.Label lbSaltBalance;
		private System.Windows.Forms.TextBox tbSaltBalance;
		private System.Windows.Forms.Label lbBetStatus;
		private System.Windows.Forms.TextBox tbBetStatus;
		private System.Windows.Forms.DataGridView dgwMatchHistory;
		private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
		private System.Windows.Forms.DataGridViewTextBoxColumn MatchTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Winner;
		private System.Windows.Forms.DataGridViewTextBoxColumn BlueOdds;
		private System.Windows.Forms.DataGridViewTextBoxColumn BluePot;
		private System.Windows.Forms.DataGridViewTextBoxColumn BlueName;
		private System.Windows.Forms.DataGridViewTextBoxColumn RedOdds;
		private System.Windows.Forms.DataGridViewTextBoxColumn RedPot;
		private System.Windows.Forms.DataGridViewTextBoxColumn RedName;
	}
}


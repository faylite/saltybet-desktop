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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.pInfo = new System.Windows.Forms.Panel();
			this.gbRed = new System.Windows.Forms.GroupBox();
			this.tbRedOdds = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbRedPot = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbRedName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbBlue = new System.Windows.Forms.GroupBox();
			this.tbBlueOdds = new System.Windows.Forms.TextBox();
			this.tbBluePot = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbBlueName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbInfo = new System.Windows.Forms.GroupBox();
			this.pMain = new System.Windows.Forms.Panel();
			this.pInfo.SuspendLayout();
			this.gbRed.SuspendLayout();
			this.gbBlue.SuspendLayout();
			this.SuspendLayout();
			// 
			// pInfo
			// 
			this.pInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pInfo.Controls.Add(this.gbRed);
			this.pInfo.Controls.Add(this.gbBlue);
			this.pInfo.Controls.Add(this.gbInfo);
			this.pInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pInfo.Location = new System.Drawing.Point(0, 512);
			this.pInfo.Name = "pInfo";
			this.pInfo.Size = new System.Drawing.Size(1210, 273);
			this.pInfo.TabIndex = 0;
			// 
			// gbRed
			// 
			this.gbRed.BackColor = System.Drawing.Color.Crimson;
			this.gbRed.Controls.Add(this.tbRedOdds);
			this.gbRed.Controls.Add(this.label6);
			this.gbRed.Controls.Add(this.tbRedPot);
			this.gbRed.Controls.Add(this.label3);
			this.gbRed.Controls.Add(this.tbRedName);
			this.gbRed.Controls.Add(this.label1);
			this.gbRed.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbRed.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRed.Location = new System.Drawing.Point(584, 0);
			this.gbRed.Name = "gbRed";
			this.gbRed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbRed.Size = new System.Drawing.Size(313, 273);
			this.gbRed.TabIndex = 3;
			this.gbRed.TabStop = false;
			this.gbRed.Text = "Red";
			// 
			// tbRedOdds
			// 
			this.tbRedOdds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRedOdds.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbRedOdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbRedOdds.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRedOdds.Location = new System.Drawing.Point(6, 227);
			this.tbRedOdds.Name = "tbRedOdds";
			this.tbRedOdds.ReadOnly = true;
			this.tbRedOdds.Size = new System.Drawing.Size(301, 34);
			this.tbRedOdds.TabIndex = 9;
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
			this.label6.Location = new System.Drawing.Point(124, 192);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(64, 26);
			this.label6.TabIndex = 8;
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
			this.tbRedPot.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRedPot.Location = new System.Drawing.Point(6, 146);
			this.tbRedPot.Name = "tbRedPot";
			this.tbRedPot.ReadOnly = true;
			this.tbRedPot.Size = new System.Drawing.Size(301, 34);
			this.tbRedPot.TabIndex = 3;
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
			this.label3.Location = new System.Drawing.Point(134, 112);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(44, 26);
			this.label3.TabIndex = 2;
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
			this.tbRedName.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRedName.Location = new System.Drawing.Point(6, 67);
			this.tbRedName.Name = "tbRedName";
			this.tbRedName.ReadOnly = true;
			this.tbRedName.Size = new System.Drawing.Size(301, 34);
			this.tbRedName.TabIndex = 1;
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
			this.label1.Location = new System.Drawing.Point(67, 28);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(179, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Character Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbBlue
			// 
			this.gbBlue.BackColor = System.Drawing.Color.RoyalBlue;
			this.gbBlue.Controls.Add(this.tbBlueOdds);
			this.gbBlue.Controls.Add(this.tbBluePot);
			this.gbBlue.Controls.Add(this.label5);
			this.gbBlue.Controls.Add(this.label4);
			this.gbBlue.Controls.Add(this.tbBlueName);
			this.gbBlue.Controls.Add(this.label2);
			this.gbBlue.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbBlue.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbBlue.Location = new System.Drawing.Point(897, 0);
			this.gbBlue.Name = "gbBlue";
			this.gbBlue.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbBlue.Size = new System.Drawing.Size(313, 273);
			this.gbBlue.TabIndex = 4;
			this.gbBlue.TabStop = false;
			this.gbBlue.Text = "Blue";
			// 
			// tbBlueOdds
			// 
			this.tbBlueOdds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBlueOdds.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbBlueOdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbBlueOdds.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBlueOdds.Location = new System.Drawing.Point(6, 227);
			this.tbBlueOdds.Name = "tbBlueOdds";
			this.tbBlueOdds.ReadOnly = true;
			this.tbBlueOdds.Size = new System.Drawing.Size(301, 34);
			this.tbBlueOdds.TabIndex = 7;
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
			this.tbBluePot.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBluePot.Location = new System.Drawing.Point(6, 146);
			this.tbBluePot.Name = "tbBluePot";
			this.tbBluePot.ReadOnly = true;
			this.tbBluePot.Size = new System.Drawing.Size(301, 34);
			this.tbBluePot.TabIndex = 5;
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
			this.label5.Location = new System.Drawing.Point(124, 192);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(64, 26);
			this.label5.TabIndex = 6;
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
			this.label4.Location = new System.Drawing.Point(134, 112);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(44, 26);
			this.label4.TabIndex = 4;
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
			this.tbBlueName.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBlueName.Location = new System.Drawing.Point(6, 67);
			this.tbBlueName.Name = "tbBlueName";
			this.tbBlueName.ReadOnly = true;
			this.tbBlueName.Size = new System.Drawing.Size(301, 34);
			this.tbBlueName.TabIndex = 1;
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
			this.label2.Location = new System.Drawing.Point(67, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "Character Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbInfo
			// 
			this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbInfo.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbInfo.Location = new System.Drawing.Point(0, 0);
			this.gbInfo.Name = "gbInfo";
			this.gbInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbInfo.Size = new System.Drawing.Size(578, 273);
			this.gbInfo.TabIndex = 5;
			this.gbInfo.TabStop = false;
			this.gbInfo.Text = "Info";
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1210, 512);
			this.pMain.TabIndex = 1;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1210, 785);
			this.Controls.Add(this.pMain);
			this.Controls.Add(this.pInfo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.Text = "SaltyBot";
			this.pInfo.ResumeLayout(false);
			this.gbRed.ResumeLayout(false);
			this.gbRed.PerformLayout();
			this.gbBlue.ResumeLayout(false);
			this.gbBlue.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pInfo;
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.GroupBox gbRed;
		private System.Windows.Forms.TextBox tbRedPot;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbRedName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbBlue;
		private System.Windows.Forms.TextBox tbBluePot;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbBlueName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbRedOdds;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbBlueOdds;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox gbInfo;
	}
}


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
			this.btnOpenDevTools = new System.Windows.Forms.Button();
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
			this.pInfo.SuspendLayout();
			this.pMain.SuspendLayout();
			this.pBlue.SuspendLayout();
			this.pRed.SuspendLayout();
			this.SuspendLayout();
			// 
			// pInfo
			// 
			this.pInfo.BackColor = System.Drawing.Color.Transparent;
			this.pInfo.Controls.Add(this.btnOpenDevTools);
			this.pInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pInfo.Location = new System.Drawing.Point(0, 512);
			this.pInfo.Name = "pInfo";
			this.pInfo.Size = new System.Drawing.Size(1210, 273);
			this.pInfo.TabIndex = 0;
			// 
			// btnOpenDevTools
			// 
			this.btnOpenDevTools.Location = new System.Drawing.Point(12, 193);
			this.btnOpenDevTools.Name = "btnOpenDevTools";
			this.btnOpenDevTools.Size = new System.Drawing.Size(199, 68);
			this.btnOpenDevTools.TabIndex = 0;
			this.btnOpenDevTools.Text = "Open Dev Tools";
			this.btnOpenDevTools.UseVisualStyleBackColor = true;
			this.btnOpenDevTools.Click += new System.EventHandler(this.btnOpenDevTools_Click);
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.Color.Transparent;
			this.pMain.Controls.Add(this.pBlue);
			this.pMain.Controls.Add(this.pRed);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1210, 512);
			this.pMain.TabIndex = 1;
			this.pMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pMain_Paint);
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
			this.pBlue.Location = new System.Drawing.Point(837, 0);
			this.pBlue.Name = "pBlue";
			this.pBlue.Size = new System.Drawing.Size(373, 512);
			this.pBlue.TabIndex = 1;
			// 
			// tbBlueOdds
			// 
			this.tbBlueOdds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBlueOdds.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbBlueOdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			this.pRed.Size = new System.Drawing.Size(373, 512);
			this.pRed.TabIndex = 0;
			// 
			// tbRedOdds
			// 
			this.tbRedOdds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRedOdds.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbRedOdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1210, 785);
			this.Controls.Add(this.pMain);
			this.Controls.Add(this.pInfo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.Text = "SaltyBot";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.pInfo.ResumeLayout(false);
			this.pMain.ResumeLayout(false);
			this.pBlue.ResumeLayout(false);
			this.pBlue.PerformLayout();
			this.pRed.ResumeLayout(false);
			this.pRed.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pInfo;
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Button btnOpenDevTools;
		private System.Windows.Forms.Panel pBlue;
		private System.Windows.Forms.Panel pRed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbRedName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbRedPot;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbRedOdds;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbBlueName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbBluePot;
		private System.Windows.Forms.TextBox tbBlueOdds;
	}
}


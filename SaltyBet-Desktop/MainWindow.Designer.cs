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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbPotRed = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCharRed = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbBlue = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tbPotBlue = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCharBlue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbInfo = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.pMain = new System.Windows.Forms.Panel();
			this.pInfo.SuspendLayout();
			this.gbRed.SuspendLayout();
			this.gbBlue.SuspendLayout();
			this.gbInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pInfo
			// 
			this.pInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pInfo.Controls.Add(this.gbRed);
			this.pInfo.Controls.Add(this.gbBlue);
			this.pInfo.Controls.Add(this.gbInfo);
			this.pInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pInfo.Location = new System.Drawing.Point(0, 475);
			this.pInfo.Name = "pInfo";
			this.pInfo.Size = new System.Drawing.Size(1227, 273);
			this.pInfo.TabIndex = 0;
			// 
			// gbRed
			// 
			this.gbRed.BackColor = System.Drawing.Color.Crimson;
			this.gbRed.Controls.Add(this.textBox2);
			this.gbRed.Controls.Add(this.label6);
			this.gbRed.Controls.Add(this.tbPotRed);
			this.gbRed.Controls.Add(this.label3);
			this.gbRed.Controls.Add(this.tbCharRed);
			this.gbRed.Controls.Add(this.label1);
			this.gbRed.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbRed.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRed.Location = new System.Drawing.Point(-3, 0);
			this.gbRed.Name = "gbRed";
			this.gbRed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbRed.Size = new System.Drawing.Size(313, 273);
			this.gbRed.TabIndex = 3;
			this.gbRed.TabStop = false;
			this.gbRed.Text = "Red";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(6, 227);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(301, 34);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "0";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(134, 192);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(44, 26);
			this.label6.TabIndex = 8;
			this.label6.Text = "Pot";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbPotRed
			// 
			this.tbPotRed.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbPotRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPotRed.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPotRed.Location = new System.Drawing.Point(6, 146);
			this.tbPotRed.Name = "tbPotRed";
			this.tbPotRed.ReadOnly = true;
			this.tbPotRed.Size = new System.Drawing.Size(301, 34);
			this.tbPotRed.TabIndex = 3;
			this.tbPotRed.Text = "0";
			this.tbPotRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
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
			// tbCharRed
			// 
			this.tbCharRed.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbCharRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCharRed.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCharRed.Location = new System.Drawing.Point(6, 67);
			this.tbCharRed.Name = "tbCharRed";
			this.tbCharRed.ReadOnly = true;
			this.tbCharRed.Size = new System.Drawing.Size(301, 34);
			this.tbCharRed.TabIndex = 1;
			this.tbCharRed.Text = "0";
			this.tbCharRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
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
			this.gbBlue.Controls.Add(this.textBox1);
			this.gbBlue.Controls.Add(this.tbPotBlue);
			this.gbBlue.Controls.Add(this.label5);
			this.gbBlue.Controls.Add(this.label4);
			this.gbBlue.Controls.Add(this.tbCharBlue);
			this.gbBlue.Controls.Add(this.label2);
			this.gbBlue.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbBlue.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbBlue.Location = new System.Drawing.Point(310, 0);
			this.gbBlue.Name = "gbBlue";
			this.gbBlue.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbBlue.Size = new System.Drawing.Size(313, 273);
			this.gbBlue.TabIndex = 4;
			this.gbBlue.TabStop = false;
			this.gbBlue.Text = "Blue";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(6, 227);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(301, 34);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbPotBlue
			// 
			this.tbPotBlue.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbPotBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPotBlue.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPotBlue.Location = new System.Drawing.Point(6, 146);
			this.tbPotBlue.Name = "tbPotBlue";
			this.tbPotBlue.ReadOnly = true;
			this.tbPotBlue.Size = new System.Drawing.Size(301, 34);
			this.tbPotBlue.TabIndex = 5;
			this.tbPotBlue.Text = "0";
			this.tbPotBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(134, 192);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(44, 26);
			this.label5.TabIndex = 6;
			this.label5.Text = "Pot";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
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
			// tbCharBlue
			// 
			this.tbCharBlue.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbCharBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCharBlue.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCharBlue.Location = new System.Drawing.Point(6, 67);
			this.tbCharBlue.Name = "tbCharBlue";
			this.tbCharBlue.ReadOnly = true;
			this.tbCharBlue.Size = new System.Drawing.Size(301, 34);
			this.tbCharBlue.TabIndex = 1;
			this.tbCharBlue.Text = "0";
			this.tbCharBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
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
			this.gbInfo.Controls.Add(this.btnUpdate);
			this.gbInfo.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbInfo.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbInfo.Location = new System.Drawing.Point(623, 0);
			this.gbInfo.Name = "gbInfo";
			this.gbInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbInfo.Size = new System.Drawing.Size(604, 273);
			this.gbInfo.TabIndex = 5;
			this.gbInfo.TabStop = false;
			this.gbInfo.Text = "Info";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(6, 208);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(592, 59);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// pMain
			// 
			this.pMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1227, 475);
			this.pMain.TabIndex = 1;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1227, 748);
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
			this.gbInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pInfo;
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.GroupBox gbRed;
		private System.Windows.Forms.TextBox tbPotRed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCharRed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbBlue;
		private System.Windows.Forms.TextBox tbPotBlue;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCharBlue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbInfo;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
	}
}


/*
 * Created by SharpDevelop.
 * User: ramazan
 * Date: 10/10/2016
 * Time: 9:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JaniSql
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button BtnBaglan;
		private System.Windows.Forms.TextBox TxtServer;
		private System.Windows.Forms.TextBox TxtKullanici;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button BtnDurum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnBaglan = new System.Windows.Forms.Button();
			this.TxtServer = new System.Windows.Forms.TextBox();
			this.TxtKullanici = new System.Windows.Forms.TextBox();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.BtnDurum = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnBaglan
			// 
			this.BtnBaglan.Location = new System.Drawing.Point(223, 161);
			this.BtnBaglan.Name = "BtnBaglan";
			this.BtnBaglan.Size = new System.Drawing.Size(75, 23);
			this.BtnBaglan.TabIndex = 0;
			this.BtnBaglan.Text = "Bağlan";
			this.BtnBaglan.UseVisualStyleBackColor = true;
			this.BtnBaglan.Click += new System.EventHandler(this.BtnBaglanClick);
			// 
			// TxtServer
			// 
			this.TxtServer.Location = new System.Drawing.Point(198, 24);
			this.TxtServer.Name = "TxtServer";
			this.TxtServer.Size = new System.Drawing.Size(100, 20);
			this.TxtServer.TabIndex = 1;
			// 
			// TxtKullanici
			// 
			this.TxtKullanici.Location = new System.Drawing.Point(198, 62);
			this.TxtKullanici.Name = "TxtKullanici";
			this.TxtKullanici.Size = new System.Drawing.Size(100, 20);
			this.TxtKullanici.TabIndex = 2;
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(198, 105);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.PasswordChar = 'J';
			this.TxtSifre.Size = new System.Drawing.Size(100, 20);
			this.TxtSifre.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Server";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Kullanıcı İsmi";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(22, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Şifre";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(22, 161);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Database Listele";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(22, 223);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 10;
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1MouseDoubleClick);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(198, 225);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 95);
			this.listBox2.TabIndex = 11;
			this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox2MouseDoubleClick);
			// 
			// BtnDurum
			// 
			this.BtnDurum.AutoSize = true;
			this.BtnDurum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BtnDurum.Location = new System.Drawing.Point(436, 24);
			this.BtnDurum.Name = "BtnDurum";
			this.BtnDurum.Size = new System.Drawing.Size(75, 23);
			this.BtnDurum.TabIndex = 12;
			this.BtnDurum.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(328, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Bağlantı Durumu";
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Location = new System.Drawing.Point(352, 225);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(120, 95);
			this.listBox3.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(22, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Database";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(198, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Table";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(352, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "Columns";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 323);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.BtnDurum);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.TxtKullanici);
			this.Controls.Add(this.TxtServer);
			this.Controls.Add(this.BtnBaglan);
			this.Name = "MainForm";
			this.Text = "JaniSql";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

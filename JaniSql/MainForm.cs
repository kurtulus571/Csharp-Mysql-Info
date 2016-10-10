/*
 * Created by SharpDevelop.
 * User: Kurtulus571
 * Web Site : http://www.janissaries.org/
 * Date: 10/10/2016
 * Time: 9:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace JaniSql
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		MySqlConnection MysqlBaglan = new MySqlConnection();
		
		void BtnBaglanClick(object sender, EventArgs e)
		{
			//Baglantı için ConnectionString oluşturuyoruz.
			MysqlBaglan.ConnectionString = "Server="+TxtServer.Text+";Uid="+TxtKullanici.Text+";Pwd='"+TxtSifre.Text+"';"; 
			//Baglantıyı açıyoruz.
			MysqlBaglan.Open();
			BtnDurum.BackColor = Color.Green;
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			MySqlCommand Komut = new MySqlCommand("Show databases",MysqlBaglan);
			MySqlDataReader Oku = Komut.ExecuteReader();
			while (Oku.Read()) {
				for (int i = 0; i < Oku.FieldCount; i++) {
					listBox1.Items.Add(Oku.GetValue(i));
				}
					
				}
			MysqlBaglan.Close();
			BtnDurum.BackColor = Color.Black;
			
	
		}
		
		void ListBox1MouseDoubleClick(object sender, MouseEventArgs e)
		{
			listBox2.Items.Clear();
			MysqlBaglan.ConnectionString = "Server="+TxtServer.Text+";Database="+listBox1.SelectedItem.ToString()+";Uid="+TxtKullanici.Text+";Pwd='"+TxtSifre.Text+"';";
			MysqlBaglan.Open();
			BtnDurum.BackColor = Color.Green;
			MySqlCommand Komut = new MySqlCommand("show tables",MysqlBaglan);
			MySqlDataReader Oku = Komut.ExecuteReader();
			while (Oku.Read()) {
				for (int i = 0; i < Oku.FieldCount; i++) {
					listBox2.Items.Add(Oku.GetValue(i));
				}
			}
			MysqlBaglan.Close();
			BtnDurum.BackColor = Color.Black;
	
		}
		void ListBox2MouseDoubleClick(object sender, MouseEventArgs e)
		{
			listBox3.Items.Clear();
			MysqlBaglan.ConnectionString = "Server="+TxtServer.Text+";Database="+listBox1.SelectedItem.ToString()+";Uid="+TxtKullanici.Text+";Pwd='"+TxtSifre.Text+"';";
			MysqlBaglan.Open();
			BtnDurum.BackColor = Color.Green;
			MySqlCommand Komut = new MySqlCommand("show columns from "+listBox2.SelectedItem.ToString(),MysqlBaglan);
			MySqlDataReader Oku = Komut.ExecuteReader();

			while (Oku.Read()) {
				listBox3.Items.Add(Oku.GetValue(0));
			}
			MysqlBaglan.Close();
			BtnDurum.BackColor = Color.Black;
	
	
		}
	}
}

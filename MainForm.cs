/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 4/28/2014
 * Time: 1:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//my own
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;


namespace mp3Player
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Player mp3player = new Player();
		
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
		

		
//		private void btnOpen_Click(object sender, EventArgs e)
//		void button1_Click(object sender, EventArgs e)
//        {
//            if (openFileDialog1.ShowDialog() == DialogResult.OK)
//            {
//                mp3player.Open(openFileDialog1.FileName);
//                txtbxFilepath.Text = openFileDialog1.FileName;
//            }
//        }
		

		

		void Button1Click(object sender, System.EventArgs e)
		{
			 if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mp3player.Open(openFileDialog1.FileName);
                txtbxFilepath.Text = openFileDialog1.FileName;
            }
		}
		
	
		
		
		void Button2Click(object sender, System.EventArgs e)
		{
			mp3player.Play();
		}
		
		void Button3Click(object sender, System.EventArgs e)
		{
			mp3player.Stop();
			txtbxFilepath.Text = "";
		}
		
	}
}

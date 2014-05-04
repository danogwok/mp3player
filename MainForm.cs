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
		
		//this method opens the music file
		void Button1Click(object sender, System.EventArgs e)
		{
			 if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mp3player.Open(openFileDialog1.FileName);
                txtFileName.Text = openFileDialog1.FileName;
            }
		}
		
		//this method plays the file		
		void Button2Click(object sender, System.EventArgs e)
		{
			mp3player.Play();
		}
		
		//this method stops the mp3 file
		void Button3Click(object sender, System.EventArgs e)
		{
			mp3player.Stop();
			txtFileName.Text = "";
		}
		
	}
}

/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 4/28/2014
 * Time: 1:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace mp3Player
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(12, 48);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Open";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Button2
			// 
			this.Button2.Location = new System.Drawing.Point(121, 48);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Play";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Button3
			// 
			this.Button3.Location = new System.Drawing.Point(227, 48);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "Stop";
			this.Button3.UseVisualStyleBackColor = true;
			// 
			// Title
			// 
			this.Title.ForeColor = System.Drawing.Color.Coral;
			this.Title.Location = new System.Drawing.Point(12, 13);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(57, 23);
			this.Title.TabIndex = 3;
			this.Title.Text = "Title";
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(97, 12);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(205, 20);
			this.txtFileName.TabIndex = 4;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(333, 83);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Name = "MainForm";
			this.Text = "mp3Player";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Button Button3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button1;
	}
}

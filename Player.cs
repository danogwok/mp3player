/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 4/28/2014
 * Time: 2:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace mp3Player
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public class Player
	{
		 //To import the dll winmn.dll which allows to play mp3 files
		[DllImport("winmm.dll")]
		private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);
		

		
		public void Open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias Music";
            mciSendString(command, null, 0, 0);
        }
		
		public void Play()
		{
			string command = "play Music";
            mciSendString(command, null, 0, 0);
		}
		
		public void Stop()
		{
			string command = "stop Music";
            mciSendString(command, null, 0, 0);

            command = "close Music";
            mciSendString(command, null, 0, 0);
		}
	}
		
}

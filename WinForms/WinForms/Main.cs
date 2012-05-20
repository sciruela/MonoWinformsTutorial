using System.Drawing;
using System.Windows.Forms;

namespace WinForms
{
	class MainClass : Form
	{
		public MainClass(){
		
		 Text = "Simple";
       Size = new Size(250, 200);
       CenterToScreen();
		}
			
		
		public static void Main (string[] args)
		{
		  Application.Run(new MainClass());
		}
	}
}

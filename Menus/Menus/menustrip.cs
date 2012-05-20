using System;  
using System.Drawing;
using System.Windows.Forms;  
  
class MForm3 : Form { 
 
  
  public MForm3() {  
    Text = "MenuStrip";  
    Size = new Size(250, 200);
  
    MenuStrip menuStrip = new MenuStrip();  
  
    ToolStripMenuItem titem1 = new ToolStripMenuItem("File");  
    menuStrip.Items.Add(titem1);  
  
    ToolStripMenuItem titem2 = new ToolStripMenuItem("Tools");  
    menuStrip.Items.Add(titem2);  
  
    ToolStripMenuItem subm1 = new ToolStripMenuItem("New");  
    subm1.Image = Image.FromFile("new.png");
    titem1.DropDownItems.Add(subm1);  
  
    ToolStripMenuItem subm2 = new ToolStripMenuItem("Open");  
    subm2.Image = Image.FromFile("open.png");
    titem1.DropDownItems.Add(subm2);  
  
    titem1.DropDownItems.Add(new ToolStripSeparator());

    ToolStripMenuItem subm3 = new ToolStripMenuItem("Exit");  
    subm3.Image = Image.FromFile("exit.png");
    titem1.DropDownItems.Add(subm3);  
  
    subm3.Click += OnExit;  
    Controls.Add(menuStrip); 
 
    MainMenuStrip = menuStrip;  

    CenterToScreen();
  }    

 public static void Main() {  
    Application.Run(new MForm3());  
  }
  
    void OnExit(object sender, EventArgs e) {
       Close();
    } 
}
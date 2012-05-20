using System;
using System.Drawing;
using System.Windows.Forms;

public class MForm4 : Form
{
  private ImageList toolBarIcons;
  private ToolBarButton save;
  private ToolBarButton exit;
  private ToolBar toolBar;

  public MForm4()
  {
    Size = new Size(250, 200);
    Text = "Simple toolbar";

    toolBar = new ToolBar();
    toolBar.Parent = this;
    toolBarIcons = new ImageList();
    save = new ToolBarButton();
    exit = new ToolBarButton();

    save.ImageIndex = 0;
    save.Tag = "Save";
    exit.ImageIndex = 1;
    exit.Tag = "Exit";

    toolBar.ImageList = toolBarIcons;
    toolBar.ShowToolTips = true;
    toolBar.Buttons.AddRange(new ToolBarButton[] {save, exit});
    toolBar.ButtonClick += new ToolBarButtonClickEventHandler(OnClicked);
    
    toolBarIcons.Images.Add(Image.FromFile("new.png"));
    toolBarIcons.Images.Add(Image.FromFile("exit.png"));

    CenterToScreen();
  }

  static void Main() 
  {
    Application.Run(new MForm4());
  }
  
  void OnClicked(object sender, ToolBarButtonClickEventArgs e) 
  {
      if (e.Button.Tag.Equals("Exit"))
          Close();
  }
}
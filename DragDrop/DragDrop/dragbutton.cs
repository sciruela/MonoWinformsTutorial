using System;
using System.Drawing;
using System.Windows.Forms;

public class MForm : Form
{
  private bool isDragging = false;
  private int oldX, oldY;
  private Button button;

  public MForm()
  {
    Text = "Drag & drop button";
    Size = new Size(270, 180);

    button = new Button();
    button.Parent = this;
    button.Cursor = Cursors.Hand;
    button.Text = "Button";
    button.Location = new Point(20, 20);

    button.MouseDown += new MouseEventHandler(OnMouseDown);
    button.MouseUp += new MouseEventHandler(OnMouseUp);
    button.MouseMove += new MouseEventHandler(OnMouseMove);

    CenterToScreen();
  }

  public static void Main() 
  {
    Application.Run(new MForm());
  }

  private void OnMouseDown(object sender, MouseEventArgs e) 
  {
    isDragging = true;
    oldX = e.X;
    oldY = e.Y;
  }

  private void OnMouseMove(object sender, MouseEventArgs e) 
  {
    if (isDragging) 
    {
        button.Top = button.Top + (e.Y - oldY); 
        button.Left = button.Left + (e.X - oldX); 
    }
  }

  private void OnMouseUp(object sender, MouseEventArgs e) 
  {
    isDragging = false;
  }
}

using System;
using System.Drawing;
using System.Windows.Forms;

public class ImageDragDrop : Form
{
  private bool isDragging;
  private int oldX, oldY;

  private Rectangle dropRect;
  private PictureBox picBox;
  private Bitmap image;
  private Brush brush;

  public ImageDragDrop()
  {
    ClientSize = new Size(350, 250);
    Text = "Dragging Image";
    Paint += new PaintEventHandler(OnPaint);
    
    isDragging = false;
    dropRect = new Rectangle(10, 10, 200, 160);
    brush = Brushes.Gray;
    picBox = new PictureBox();
    loadImage();

    picBox.Parent = this;
    picBox.Location = new Point(100, 50);
    picBox.Size = new Size(image.Width, image.Height);
    picBox.Image = image;
    picBox.Cursor = Cursors.Hand;

    picBox.MouseDown += new MouseEventHandler(OnMouseDown);
    picBox.MouseUp += new MouseEventHandler(OnMouseUp);
    picBox.MouseMove += new MouseEventHandler(OnMouseMove);

    CenterToScreen();
  }


  void loadImage() {
      try {
          image = new Bitmap("image.jpg");
      } catch {
          Console.WriteLine("Error reading image");
          Environment.Exit(1);
      }
  }

  public static void Main() 
  {
    Application.Run(new ImageDragDrop());
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
      picBox.Top = picBox.Top + (e.Y - oldY);
      picBox.Left = picBox.Left + (e.X - oldX);
    }
  }

  private void OnMouseUp(object sender, MouseEventArgs e) 
  {
    isDragging = false;

    if(dropRect.Contains(picBox.Bounds)) {
        brush = Brushes.Gold;
    } else {
        brush = Brushes.Gray;
    }

    Refresh();
  }

  private void OnPaint(object sender, PaintEventArgs e)
  {
    Graphics g = e.Graphics;
    g.FillRectangle(brush, dropRect);
  }
}

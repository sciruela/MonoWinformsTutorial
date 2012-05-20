using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class MForm4 : Form {

    public MForm4() {
        Text = "Gradients";
        Size = new Size(350, 350);

        Paint += new PaintEventHandler(OnPaint);

        CenterToScreen();
    }


    void OnPaint(object sender, PaintEventArgs e)
    {      
        Graphics g = e.Graphics;

        Point pt1 = new Point(5, 5);
        Point pt2 = new Point(25, 25);
        Brush lg = new LinearGradientBrush(pt1, pt2, Color.Red, Color.Black);
        g.FillRectangle(lg, 20, 20, 300, 40);
        
        pt1 = new Point(5, 25);
        pt2 = new Point(20, 2);
        lg = new LinearGradientBrush(pt1, pt2, Color.Yellow, Color.Black);
        g.FillRectangle(lg, 20, 80, 300, 40);

        pt1 = new Point(5, 25);
        pt2 = new Point(2, 2);
        lg = new LinearGradientBrush(pt1, pt2, Color.Green, Color.Black);
        g.FillRectangle(lg, 20, 140, 300, 40);

        pt1 = new Point(25, 25);
        pt2 = new Point(15, 25);
        lg = new LinearGradientBrush(pt1, pt2, Color.Blue, Color.Black);
        g.FillRectangle(lg, 20, 200, 300, 40);
        
        pt1 = new Point(0, 10);
        pt2 = new Point(0, 20);
        lg = new LinearGradientBrush(pt1, pt2, Color.Orange, Color.Black);
        g.FillRectangle(lg, 20, 260, 300, 40);            

        lg.Dispose();
        g.Dispose();
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm4());
    }
}
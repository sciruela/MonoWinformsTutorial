using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class MForm2 : Form {

    public MForm2() {
        Text = "Colors";
        Size = new Size(360, 300);

        Paint += new PaintEventHandler(OnPaint);

        CenterToScreen();
    }


    void OnPaint(object sender, PaintEventArgs e)
    {      
        Graphics g = e.Graphics;
            
        g.FillRectangle(Brushes.Sienna, 10, 15, 90, 60);
        g.FillRectangle(Brushes.Green, 130, 15, 90, 60);
        g.FillRectangle(Brushes.Maroon, 250, 15, 90, 60);
        g.FillRectangle(Brushes.Chocolate, 10, 105, 90, 60);
        g.FillRectangle(Brushes.Gray, 130, 105, 90, 60);
        g.FillRectangle(Brushes.Coral, 250, 105, 90, 60);
        g.FillRectangle(Brushes.Brown, 10, 195, 90, 60);
        g.FillRectangle(Brushes.Teal, 130, 195, 90, 60);
        g.FillRectangle(Brushes.Goldenrod, 250, 195, 90, 60);

        g.Dispose();

    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm2());
    }
}

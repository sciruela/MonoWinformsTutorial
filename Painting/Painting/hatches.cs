using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class MForm3 : Form {

    public MForm3() {
        Text = "Hatches";
        Size = new Size(360, 300);

        Paint += new PaintEventHandler(OnPaint);

        CenterToScreen();
    }


    void OnPaint(object sender, PaintEventArgs e)
    {      
        Graphics g = e.Graphics;
            
        HatchBrush hb = new HatchBrush(HatchStyle.Cross, Color.Black, this.BackColor);
        g.FillRectangle(hb, 10, 15, 90, 60);

        hb = new HatchBrush(HatchStyle.Percent05, Color.Black, this.BackColor);
        g.FillRectangle(hb, 130, 15, 90, 60);

        hb = new HatchBrush(HatchStyle.SolidDiamond, Color.Black, this.BackColor);
        g.FillRectangle(hb, 250, 15, 90, 60);

        hb = new HatchBrush(HatchStyle.DiagonalBrick, Color.Black, this.BackColor);
        g.FillRectangle(hb, 10, 105, 90, 60);

        hb = new HatchBrush(HatchStyle.Divot, Color.Black, this.BackColor);
        g.FillRectangle(hb, 130, 105, 90, 60);

        hb = new HatchBrush(HatchStyle.Wave, Color.Black, this.BackColor);
        g.FillRectangle(hb, 250, 105, 90, 60);

        hb = new HatchBrush(HatchStyle.ZigZag, Color.Black, this.BackColor);
        g.FillRectangle(hb, 10, 195, 90, 60);

        hb = new HatchBrush(HatchStyle.Sphere, Color.Black, this.BackColor);
        g.FillRectangle(hb, 130, 195, 90, 60);

        hb = new HatchBrush(HatchStyle.Shingle, Color.Black, this.BackColor);
        g.FillRectangle(hb, 250, 195, 90, 60);

        hb.Dispose();
        g.Dispose();
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm3());
    }
}

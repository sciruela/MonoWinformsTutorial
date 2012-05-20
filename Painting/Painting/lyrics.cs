using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class MForm5 : Form {

    public MForm5() {

        Text = "You know I'm No Good";
        Size = new Size(380, 450);

        Paint += new PaintEventHandler(OnPaint);
        CenterToScreen();
    }


    void OnPaint(object sender, PaintEventArgs e)
    {      
        Graphics g = e.Graphics;
             
        Font ft = new Font("Purisa", 10);
        SolidBrush br = new SolidBrush(Color.Black);

        PointF pt = new PointF(20.0f, 20.0f);             
        g.DrawString("Meet you downstairs in the bar and heard", ft, br, pt);

        pt = new PointF(20.0f, 50.0f);             
        g.DrawString("Your rolled up sleeves and your skull t-shirt", ft, br, pt);

        pt = new PointF(20.0f, 80.0f);             
        g.DrawString("You say why did you do it with him today?", ft, br, pt);

        pt = new PointF(20.0f, 110.0f);             
        g.DrawString("And sniffed me out like I was tanqueray", ft, br, pt);

        pt = new PointF(20.0f, 160.0f);             
        g.DrawString("Cause you’re my fella, my guy", ft, br, pt);

        pt = new PointF(20.0f, 190.0f);             
        g.DrawString("Hand me your stella and fly", ft, br, pt);

        pt = new PointF(20.0f, 220.0f);             
        g.DrawString("By the time I’m out the door", ft, br, pt);

        pt = new PointF(20.0f, 250.0f);             
        g.DrawString("You tear me down like roger moore", ft, br, pt);

        pt = new PointF(20.0f, 300.0f);             
        g.DrawString("I cheated myself", ft, br, pt);

        pt = new PointF(20.0f, 330.0f);             
        g.DrawString("Like I knew I would", ft, br, pt);

        pt = new PointF(20.0f, 360.0f);             
        g.DrawString("I told ya, I was trouble", ft, br, pt);

        pt = new PointF(20.0f, 390.0f);             
        g.DrawString("You know that I’m no good", ft, br, pt);

        g.Dispose();
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm5());
    }
}

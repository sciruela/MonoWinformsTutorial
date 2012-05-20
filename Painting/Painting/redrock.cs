using System;
 using System.Drawing;
 using System.Windows.Forms;

class MForm6 : Form {

    private Bitmap castle;

    public MForm6() {
        Text = "Red Rock";
        loadImage();
        ClientSize = new Size(castle.Width, castle.Height);

        Paint += new PaintEventHandler(OnPaint);

        CenterToScreen();
    }

    void loadImage() {
        try {    
            castle = new Bitmap("redrock.png");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            Environment.Exit(1);
        }
    }

    void OnPaint(object sender, PaintEventArgs e)
    {      
      Graphics g = e.Graphics;

      Rectangle r = new Rectangle(1, 1, castle.Width, castle.Height);
      g.DrawImage(castle, r);
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm6());
    }
}

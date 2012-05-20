using System;
using System.Drawing;
using System.Windows.Forms;


class MForm3 : Form {
 
    PictureBox pb;
    TrackBar tb;
    Bitmap mute, min, med, max;

    public MForm3() {
        Text = "TrackBar";
        Size = new Size(260, 190);

        tb = new TrackBar();
        tb.Parent = this;
        tb.Size = new Size(160, 30);
        tb.Location = new Point(20, 40);
        tb.TickStyle = TickStyle.None;

        tb.ValueChanged += new EventHandler(OnChanged);
        
        LoadImages();

        pb = new PictureBox();
        pb.Parent = this;
        pb.Location = new Point(210, 50);
        pb.Image = mute;
        
        CenterToScreen();

    }

    void LoadImages() {
        mute = new Bitmap("mute.png");
        min = new Bitmap("min.png");
        med = new Bitmap("med.png");
        max = new Bitmap("max.png");
    }


    void OnChanged(object sender, EventArgs e) {
        int val = tb.Value;

        if (val == 0) {
            pb.Image = mute;
        } else if (val > 0 && val <= 3) {
            pb.Image = min;
        } else if (val > 3 && val < 8) {
            pb.Image = med;
        } else {
            pb.Image = max;
        }
    }
}

/*class MApplication {
    public static void Main() {
        Application.Run(new MForm3());
    }
}*/
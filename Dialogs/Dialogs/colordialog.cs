using System;
 using System.Drawing;
 using System.Windows.Forms;

class MForm2 : Form {

    private ToolBar toolbar;
    private ToolBarButton open;
    private Color color;

    private int rectWidth = 100;
    private int rectHeight = 100;
    private Rectangle r;

    public MForm2() {
        Text = "ColorDialog";

        color = Color.Blue;
 
        toolbar = new ToolBar();
        open = new ToolBarButton();

        toolbar.Buttons.Add(open);
        toolbar.ButtonClick += new ToolBarButtonClickEventHandler(OnClicked);

        LocateRect();

        SetStyle (ControlStyles.ResizeRedraw, true);
        Controls.Add(toolbar);
        Paint += new PaintEventHandler(OnPaint);

        CenterToScreen();
    }


    void OnPaint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      LocateRect();

      SolidBrush brush = new SolidBrush(color);

      g.FillRectangle(brush, r);
    }


    void OnClicked(object sender, ToolBarButtonClickEventArgs e) {
       ColorDialog dialog = new ColorDialog();
       if (dialog.ShowDialog(this) == DialogResult.OK) {
          color = dialog.Color;
          Invalidate();
       }
    }

    void LocateRect() {
        int x = (ClientSize.Width - rectWidth) / 2;
        int y = (ClientSize.Height - rectHeight) / 2;
        r = new Rectangle(x, y, rectWidth, rectHeight);
    }
}


class MApplication {
    public static void Main() {
        Application.Run(new MForm2());
    }
}
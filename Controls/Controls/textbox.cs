using System;
using System.Drawing;
using System.Windows.Forms;

class MForm6 : Form {

    private Label text;

    public MForm6() {
        Text = "TextBox";
        Size = new Size(250, 200);
        CenterToScreen();

        text = new Label();
        text.Parent = this;
        text.Text = "...";
        text.Location = new Point(60, 40);
        text.AutoSize = true;

        TextBox tbox = new TextBox();
        tbox.Parent = this;
        tbox.Location = new Point(60, 100);
        tbox.KeyUp += new KeyEventHandler(OnKeyUp);

    }

    void OnKeyUp(object sender, KeyEventArgs e) {
        TextBox tb = (TextBox) sender;
        this.text.Text = tb.Text;
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm6());
    }
}

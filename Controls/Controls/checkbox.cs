using System;
using System.Drawing;
using System.Windows.Forms;

class MForm2 : Form {

    private CheckBox cb;

    public MForm2() {
        Text = "CheckBox";
        Size = new Size(220, 170);

        cb = new CheckBox();
        cb.Parent = this;
        cb.Location = new Point(30, 30);
        cb.Text = "Show Title";
        cb.Checked = true;

        cb.CheckedChanged += new EventHandler(OnChanged);

        CenterToScreen();
    }

    void OnChanged(object sender, EventArgs e) {
        if (cb.Checked) {
            Text = "CheckBox";
        } else {
            Text = "";
        }
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm2());
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

class MForm4 : Form {

    private ComboBox cb;
    private Label label;

    public MForm4() {
        Text = "ComboBox";
        Size = new Size(240, 240);

        cb = new ComboBox();
        cb.Parent = this;
        cb.Location = new Point(50, 30);

        cb.Items.AddRange(new object[] {"Ubuntu",
            "Mandriva",
            "Red Hat",
            "Fedora",
            "Gentoo"});

        cb.SelectionChangeCommitted += new EventHandler(OnChanged);

        label = new Label();
        label.Location = new Point(50, 140);
        label.Parent = this;
        label.Text = "...";

        CenterToScreen();
    }

    void OnChanged(object sender, EventArgs e) {
         ComboBox combo = (ComboBox) sender;
         label.Text = combo.Text;
    }
}


/*class MApplication {
    public static void Main() {
        Application.Run(new MForm4());
    }
}*/
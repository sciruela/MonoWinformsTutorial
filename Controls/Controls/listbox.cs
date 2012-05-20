using System;
using System.Drawing;
using System.Windows.Forms;

class MForm7 : Form {

    private StatusBar sb;

    public MForm7() {
        Text = "ListBox";
        Size = new Size(210, 210);

        ListBox lb = new ListBox();
        lb.Parent = this;
        lb.Items.Add("Jessica");
        lb.Items.Add("Rachel");
        lb.Items.Add("Angelina");
        lb.Items.Add("Amy");
        lb.Items.Add("Jennifer");
        lb.Items.Add("Scarlett");

        lb.Dock = DockStyle.Fill;
        lb.SelectedIndexChanged += new EventHandler(OnChanged);

        sb = new StatusBar();
        sb.Parent = this;

        CenterToScreen();
    }


    void OnChanged(object sender, EventArgs e) {
        ListBox lb = (ListBox) sender;
        sb.Text = lb.SelectedItem.ToString();
    }
}

/*class MApplication {
    public static void Main() {
        Application.Run(new MForm7());
    }
}*/
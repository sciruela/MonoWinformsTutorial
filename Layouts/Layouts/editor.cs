using System;
using System.Drawing;
using System.Windows.Forms;

class MForm2 : Form {


    public MForm2() {
        Text = "Editor";
        Size = new Size(210, 180);

        MainMenu mainMenu = new MainMenu();
        MenuItem file = mainMenu.MenuItems.Add("&File");
        file.MenuItems.Add(new MenuItem("E&xit",
                 new EventHandler(this.OnExit), Shortcut.CtrlX));

        Menu = mainMenu;

        TextBox tb = new TextBox();
        tb.Parent = this;
        tb.Dock = DockStyle.Fill;
        tb.Multiline = true;

        StatusBar sb = new StatusBar();
        sb.Parent = this;
        sb.Text = "Ready";

        CenterToScreen();
    }

    void OnExit(object sender, EventArgs e) {
        Close();
    }
}


class MApplication2 {
    public static void Main() {
        Application.Run(new MForm2());
    }
}
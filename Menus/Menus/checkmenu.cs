using System;
using System.Drawing;
using System.Windows.Forms;

class MForm2 : Form {

    private StatusBar sb;
    private MenuItem viewStatusBar;

    public MForm2() {
        Text = "Check menu item";

        sb = new StatusBar();
        sb.Parent = this;
        sb.Text = "Ready";

        MainMenu mainMenu = new MainMenu();

        MenuItem file = mainMenu.MenuItems.Add("&File");          
        file.MenuItems.Add(new MenuItem("E&xit", 
            new EventHandler(OnExit), Shortcut.CtrlX));

        MenuItem view = mainMenu.MenuItems.Add("&View");
        viewStatusBar = new MenuItem("View StatusBar");
        viewStatusBar.Checked = true;
        viewStatusBar.Click += new EventHandler(ToggleStatusBar);
        view.MenuItems.Add(viewStatusBar);

        Menu = mainMenu;
        Size = new Size(250, 200);

        CenterToScreen();
    }

    void OnExit(object sender, EventArgs e) {
       Close();
    }

    void ToggleStatusBar(object sender, EventArgs e) {
        bool check = viewStatusBar.Checked;
        if (check) {
            sb.Visible = false;
            viewStatusBar.Checked = false;
        } else {
            sb.Visible = true;
            viewStatusBar.Checked = true;
        }
    }

}

class MApplication {
    public static void Main() {
        Application.Run(new MForm2());
    }
}

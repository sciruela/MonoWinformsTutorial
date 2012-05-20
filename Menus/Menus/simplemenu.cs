using System;
using System.Drawing;
using System.Windows.Forms;

class MForm : Form {

    public MForm() {
        Text = "Submenu";

        MenuStrip ms = new MenuStrip();
        ms.Parent = this;

        ToolStripMenuItem file = new ToolStripMenuItem("&File");   
        ToolStripMenuItem exit = new ToolStripMenuItem("&Exit", null,
            new EventHandler(OnExit));       

        ToolStripMenuItem import = new ToolStripMenuItem();
        import.Text = "Import";

        file.DropDownItems.Add(import);

        ToolStripMenuItem temp = new ToolStripMenuItem();
        temp.Text = "Import newsfeed list...";
        import.DropDownItems.Add(temp);

        temp = new ToolStripMenuItem();
        temp.Text = "Import bookmarks...";
        import.DropDownItems.Add(temp);

        temp = new ToolStripMenuItem();
        temp.Text = "Import mail...";
        import.DropDownItems.Add(temp);

        file.DropDownItems.Add(exit);

        ms.Items.Add(file);
        MainMenuStrip = ms;
        Size = new Size(380, 200);

        CenterToScreen();
    }

    void OnExit(object sender, EventArgs e) {
       Close();
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm());
    }
}

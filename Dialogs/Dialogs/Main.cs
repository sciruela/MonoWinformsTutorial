using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

class MForm : Form {

    private ToolBar toolbar;
    private ToolBarButton open;
    private StatusBar statusbar;

    public MForm() {
        Text = "FolderBrowserDialog";
 
        toolbar = new ToolBar();
        open = new ToolBarButton();

        statusbar = new StatusBar();
        statusbar.Parent = this;

        toolbar.Buttons.Add(open);
        toolbar.ButtonClick += new ToolBarButtonClickEventHandler(OnClicked);

        Controls.Add(toolbar);

        CenterToScreen();
    }


    void OnClicked(object sender, ToolBarButtonClickEventArgs e) {
       FolderBrowserDialog dialog = new FolderBrowserDialog();

       if (dialog.ShowDialog(this) == DialogResult.OK) {
           statusbar.Text = dialog.SelectedPath;
       }
    }
}


class MApplication {
    public static void Main() {
        Application.Run(new MForm());
    }
}


using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

class MForm4 : Form {

    private ToolBar toolbar;
    private ToolBarButton open;
    private TextBox textbox;

    public MForm4() {
        Text = "OpenFileDialog";

        toolbar = new ToolBar();
        open = new ToolBarButton();

        textbox = new TextBox();
        textbox.Multiline = true;
        textbox.ScrollBars = ScrollBars.Both;
        textbox.WordWrap = false;
        textbox.Parent = this;
        textbox.Dock = DockStyle.Fill;
       

        toolbar.Buttons.Add(open);
        toolbar.ButtonClick += new ToolBarButtonClickEventHandler(OnClicked);

        Controls.Add(toolbar);
        Controls.Add(textbox);

 	CenterToScreen();
    }

    void OnClicked(object sender, ToolBarButtonClickEventArgs e) {
       OpenFileDialog dialog = new OpenFileDialog();
       dialog.Filter = "C# files (*.cs)|*.cs";

       if (dialog.ShowDialog(this) == DialogResult.OK) {
           StreamReader reader = new StreamReader(dialog.FileName);
           string data = reader.ReadToEnd();
           reader.Close();
           textbox.Text = data;
       }
    }
}


class MApplication {
    public static void Main() {
        Application.Run(new MForm4());
    }
}
using System;
 using System.Drawing;
 using System.Windows.Forms;

class MForm3 : Form {

    private Label text;
    private ToolBar toolbar;
    private ToolBarButton open;

    public MForm3() {
        Text = "FontDialog";

        text = new Label();
        text.Parent = this;
        text.Text = "Winforms tutorial";

        LocateText();
 
        toolbar = new ToolBar();
        toolbar.Parent = this;
        open = new ToolBarButton();

        toolbar.Buttons.Add(open);
        toolbar.ButtonClick += new ToolBarButtonClickEventHandler(OnClicked);

        text.AutoSize = true;
        Resize += new EventHandler(OnResize);

        CenterToScreen();
    }

    void OnResize(object sender, EventArgs e){
       LocateText();
    }

    void OnClicked(object sender, ToolBarButtonClickEventArgs e) {
       FontDialog dialog = new FontDialog();
       if (dialog.ShowDialog(this) == DialogResult.OK) {
          text.Font = dialog.Font;
          LocateText();
       }
    }

    void LocateText() {
        text.Top = (this.ClientSize.Height - text.Height) / 2;
        text.Left = (this.ClientSize.Width - text.Width) / 2;
    }
}


class MApplication {
    public static void Main() {
        Application.Run(new MForm3());
    }
}
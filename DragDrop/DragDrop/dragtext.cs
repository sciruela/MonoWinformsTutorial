using System;
using System.Drawing;
using System.Windows.Forms;

public class MForm2 : Form
{

    private TextBox textBox;
    private Button button;

    public MForm2()
    {
        InitForm();
        CenterToScreen();
    }

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
        TextBox txt = (TextBox) sender;
        txt.DoDragDrop(txt.Text, DragDropEffects.Copy);
    }

    private void OnDragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Copy;
    }

    private void OnDragDrop(object sender, DragEventArgs e)
    {
        Button button = (Button) sender;
        button.Text = (string) e.Data.GetData(DataFormats.Text);
    }


    private void InitForm()
    {
        Text = "Drag & drop";
        button = new Button();
        textBox = new TextBox();
        SuspendLayout();

        button.AllowDrop = true;
        button.Location = new Point(150, 50);
        textBox.Location = new Point(15, 50);

        button.DragDrop += new DragEventHandler(OnDragDrop);
        button.DragEnter += new DragEventHandler(OnDragEnter);
        textBox.MouseDown += new MouseEventHandler(OnMouseDown);

        ClientSize = new Size(250, 200);
        Controls.Add(button);
        Controls.Add(textBox);
        ResumeLayout();
    }

   public static void Main(string[] args)
    {
        Application.Run(new MForm2());
    }

}
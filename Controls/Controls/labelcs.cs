using System;
using System.Drawing;
using System.Windows.Forms;

class MForm : Form {

   string text = @"Sometimes I feel I've got to
Run away I've got to
Get away
From the pain that you drive
    into the heart of me
The love we share
Seems to go nowhere
I've lost my lights
I toss and turn I can't sleep at night

Once I ran to you (I ran)
Now I'll run from you
This tainted love you've given
I give you all a boy could give you
Take my tears and that's not nearly all
Tainted love
Tainted love";

    public MForm() {
        Text = "Tainted Love";

        Font font = new Font("Serif", 10);

        Label lyrics = new Label();
        lyrics.Parent = this;
        lyrics.Text = text;
        lyrics.Font = font;
        lyrics.Location = new Point(10, 10);
        lyrics.Size = new Size (290, 290);

        CenterToScreen();

    }
}

//class MApplication {
//    public static void Main() {
//        Application.Run(new MForm());
//    }
//}
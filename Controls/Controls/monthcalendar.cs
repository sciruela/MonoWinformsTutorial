using System;
using System.Drawing;
using System.Windows.Forms;

class MForm5 : Form {

   private MonthCalendar calendar;
   private Label date;

    public MForm5() {
        Text = "Month Calendar";
        Size = new Size(240, 240);

        calendar = new MonthCalendar();
        calendar.Parent = this;
        calendar.Location = new Point(20, 20);
        calendar.DateSelected += new DateRangeEventHandler(OnSelected);

        date = new Label();
        date.Location = new Point(40, 170);
        date.Parent = this;
        DateTime dt = calendar.SelectionStart;
        date.Text = dt.Month + "/" + dt.Day + "/" + dt.Year;

        CenterToScreen();
    }

    void OnSelected(object sender, EventArgs e) {
        DateTime dt = calendar.SelectionStart;
        date.Text = dt.Month + "/" + dt.Day + "/" + dt.Year;
    }
}


/*class MApplication {
    public static void Main() {
        Application.Run(new MForm5());
    }
}
*/
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;



public class Board : UserControl {

    private const int WIDTH = 300;
    private const int HEIGHT = 300;
    private const int DOT_SIZE = 10;
    private const int ALL_DOTS = 900;
    private const int RAND_POS = 27;

    private int[] x = new int[ALL_DOTS];
    private int[] y = new int[ALL_DOTS];

    private int dots;
    private int apple_x;
    private int apple_y;

    private bool left = false;
    private bool right = true;
    private bool up = false;
    private bool down = false;
    private bool inGame = true;

    private Timer timer;

    private Bitmap dot;
    private Bitmap apple;
    private Bitmap head;

    private IContainer components;
    
    public int BORDER_WIDTH;
    public int TITLEBAR_HEIGHT;

    public Board() {

        components = new Container();
        BackColor = Color.Black;
        DoubleBuffered = true;
        this.ClientSize = new Size(WIDTH, HEIGHT);

        try {
            dot = new Bitmap("dot.png");
            apple = new Bitmap("apple.png");
            head = new Bitmap("head.png");

        } catch (Exception e) {
            Console.WriteLine(e.Message);
            Environment.Exit(1);
        } 

        initGame();
    }

    private void OnTick(object sender, EventArgs e) {

        if (inGame) {
            checkApple();
            checkCollision();
            move();
        }
        this.Refresh();
    }


    private void initGame() {

        dots = 3;

        for (int z = 0; z < dots; z++) {
            x[z] = 50 - z * 10;
            y[z] = 50;
        }

        locateApple();
        KeyUp += new KeyEventHandler(OnKeyUp);


        timer = new Timer(this.components);
        timer.Enabled = true;
        timer.Interval = 100;
        timer.Tick += new System.EventHandler(this.OnTick);

        Paint += new PaintEventHandler(this.OnPaint);


    }


    private void OnPaint(object sender, PaintEventArgs e) {

        Graphics g = e.Graphics;

        if (inGame) {

            g.DrawImage(apple, apple_x, apple_y);

            for (int z = 0; z < dots; z++) {
                if (z == 0) {
                    g.DrawImage(head, x[z], y[z]);
                } else {
                    g.DrawImage(dot, x[z], y[z]);    
                }
            }

        } else {
            gameOver(g);
        }
    }


    private void gameOver(Graphics g) {

        String msg = "Game Over";
        StringFormat format = new StringFormat();
        format.Alignment = StringAlignment.Center;
        format.LineAlignment = StringAlignment.Center;
        
        g.DrawString(msg, Font, Brushes.White, ClientRectangle, format);
        timer.Stop();
    }


    private void checkApple() {

        if ((x[0] == apple_x) && (y[0] == apple_y)) {
            dots++;
            locateApple();
        }
    }

    private void move() {

        for (int z = dots; z > 0; z--) {
            x[z] = x[(z - 1)];
            y[z] = y[(z - 1)];
        }

        if (left) {
            x[0] -= DOT_SIZE;
        }

        if (right) {
            x[0] += DOT_SIZE;
        }

        if (up) {
            y[0] -= DOT_SIZE;
        }

        if (down) {
            y[0] += DOT_SIZE;
        }
    }

    private void checkCollision() {

        for (int z = dots; z > 0; z--) {
            if ((z > 4) && (x[0] == x[z]) && (y[0] == y[z])) {
                inGame = false;
            }
        }

        if (y[0] > HEIGHT - DOT_SIZE - TITLEBAR_HEIGHT - BORDER_WIDTH) {
            inGame = false;
        }

        if (y[0] < 0) {
            inGame = false;
        }

        if (x[0] > WIDTH - DOT_SIZE - 2 * BORDER_WIDTH) {
            inGame = false;
        }

        if (x[0] < 0) {
            inGame = false;
        }
    }

    private void locateApple() {
        Random rand = new Random();
        int r = (int)(rand.Next(RAND_POS));
        apple_x = ((r * DOT_SIZE));
        r = (int)(rand.Next(RAND_POS));
        apple_y = ((r * DOT_SIZE));
    }


    private void OnKeyUp(object sender, KeyEventArgs e) {

        int key = (int) e.KeyCode;

        if ((key == (int) Keys.Left) && (!right)) {
            left = true;
            up = false;
            down = false;
        }

        if ((key == (int) Keys.Right) && (!left)) {
            right = true;
            up = false;
            down = false;
        }

        if ((key == (int) Keys.Up) && (!down)) {
            up = true;
            right = false;
            left = false;
        }

        if ((key == (int) Keys.Down) && (!up)) {
            down = true;
            right = false;
            left = false;
        }
    }
}
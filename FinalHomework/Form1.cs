
using System.Drawing;

namespace FinalHomework
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen = new Pen(Color.Gray, 5);
        SolidBrush brush = new SolidBrush(Color.Red);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
           
            pen.Color = Color.Black;
            brush.Color = Color.Orange;
            graphics.FillRectangle(brush, 200, 271, 500, 400);
            graphics.DrawRectangle(pen, 200, 271, 500, 400);
            
            DrawTriangle(graphics);
            brush.Color=Color.White;
            graphics.FillEllipse(brush, 400, 100, 100, 100);
            pen.Color = Color.Green;
            graphics.DrawEllipse(pen, 400, 100, 100, 100);


            pen.Color=Color.DarkRed;
            graphics.FillRectangle(brush, 230, 350, 130, 310);
            graphics.DrawRectangle(pen, 230, 350, 130, 310);

            Point line1_start = new Point(230, 350);
            Point line2_start = new Point(230, 660);
            Point lines_end = new Point(360, 505);

            graphics.DrawLine(pen, line1_start, lines_end);
            graphics.DrawLine(pen, line2_start, lines_end);


            graphics.FillRectangle(brush, 470, 350, 90, 180);
            graphics.DrawRectangle(pen, 470, 350, 90, 180);

            graphics.FillRectangle(brush, 560, 350, 90, 180);
            graphics.DrawRectangle(pen, 560, 350, 90, 180);

        }

        private void DrawTriangle(Graphics g)
        {
            Point[] points = {
                new Point(150, 271), 
                new Point(450, 60), 
                new Point(750, 271)  
            };

            Pen trianglePen = new Pen(Color.Blue, 2);
            SolidBrush triangleBrush = new SolidBrush(Color.DarkRed);

            g.FillPolygon(triangleBrush, points);
            g.DrawPolygon(trianglePen, points);
            trianglePen.Dispose();
            triangleBrush.Dispose();
        }

    }
}

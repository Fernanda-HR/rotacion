namespace rotacion
{
    public partial class Form1 : Form
    {
        static Bitmap bmp; 
        static Graphics g;
       

         Point a = new Point(0, 0);
         Point b = new Point(0, 100);
         Point c = new Point(100, 100);
         Point d = new Point(100, 0);



        private void button1_Click(object sender, EventArgs e)
        {
            Render();



        }
        private PointF Translate(PointF a, PointF b)
        {
            new Point();
            //return new Point((int)a.X + (int)b.X, (int)a.Y + (int)a.Y);
            return new PointF(a.X + b.X, a.Y + b.Y);
        }
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            g.DrawLine(Pens.Gray, a, b);
            g.DrawLine(Pens.Gray, b, c);
            g.DrawLine(Pens.Gray, c, d);
            g.DrawLine(Pens.Gray, d, a);



        }
        private void Render()
        {
            

            g.Clear(Color.Transparent);
            g.DrawLine(Pens.Yellow, bmp.Width / 2, 0, bmp.Width / 2, bmp.Height); 
            g.DrawLine(Pens.Yellow, 0, bmp.Height / 2, bmp.Width, bmp.Height / 2);
            RenderLine(a, b);
            RenderLine(b, c);
            RenderLine(c, d);
            RenderLine(d, a);//*/
            pictureBox1.Invalidate();
        }

        private PointF Rotate(PointF a)
        {
            float num = (float.Parse(textBox1.Text))/ 57.2958f;

            PointF b = new PointF();

            b.X = (float)((a.X * Math.Cos(num)) - (a.Y * Math.Sin(num)));
            b.Y = (float)((a.X * Math.Sin(num)) + (a.Y * Math.Cos(num))); 
            return b;
        }

        private PointF TranslateToCenter(PointF a)
        {
            int Sx = (pictureBox1.Width / 2);  // origen central en x
            int Sy = (pictureBox1.Height / 2); // origen central en y
            return new PointF(Sx + a.X, Sy - a.Y);

        }

        private void RenderLine(PointF a, PointF b)
        {
            a = Translate(a, new PointF(-50, -50)); // centroide
            b = Translate(b, new PointF(-50, -50)); // centroide
            PointF c = Rotate(a);
            PointF d = Rotate(b);//*/
            c = TranslateToCenter(c);
            d = TranslateToCenter(d);
            c = Translate(c, new PointF(50, -50));
            d = Translate(d, new PointF(50, -50));
            g.DrawLine(Pens.Gray, c, d);
        }//*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        // ����������� �����
        public Form1()
        {
            InitializeComponent();
            this.Text = "������ ������� z(t)";
            this.Size = new Size(800, 600);
            this.Resize += new EventHandler(OnResize);
        }

        // ���� ��� t
        private double step = 0.4;

        // ĳ������ t
        private double tMin = 2.4;
        private double tMax = 6.9;

        // �����, �� ������� �� ��������� �������
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            Pen axisPen = new Pen(Color.Black, 2);
            Pen graphPen = new Pen(Color.Blue, 2);

            // ��������� ����� �����
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // ������� ��
            g.DrawLine(axisPen, 0, centerY, this.ClientSize.Width, centerY); // ��� X
            g.DrawLine(axisPen, centerX, 0, centerX, this.ClientSize.Height); // ��� Y

            // �������
            double scaleX = this.ClientSize.Width / (tMax - tMin);
            double scaleY = this.ClientSize.Height / 10.0; // ������ ���������� ������� ��� Y

            // ���������� � ��������� ������� �������
            for (double t = tMin; t <= tMax; t += step)
            {
                // ���������� z
                double z1 = (t + Math.Sin(2 * t)) / (t * t - 3);
                double z2 = ((t + step) + Math.Sin(2 * (t + step))) / ((t + step) * (t + step) - 3);

                // ������������� ���������
                int x1 = centerX + (int)((t - tMin) * scaleX);
                int y1 = centerY - (int)(z1 * scaleY);

                int x2 = centerX + (int)(((t + step) - tMin) * scaleX);
                int y2 = centerY - (int)(z2 * scaleY);

                // ������� �� �������
                g.DrawLine(graphPen, x1, y1, x2, y2);
            }

            // ��������� �������
            axisPen.Dispose();
            graphPen.Dispose();
        }

        // ����� ��� ����������� ��� ��� ������ ����
        private void OnResize(object sender, EventArgs e)
        {
            this.Invalidate(); // ������������� ���� �����
        }

        // �������� ����� ������� ��������
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ̳��� ��� ����, �� ���������� �� ��� ������������ �����
        }
    }
}

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int points = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            points++;
            button1.Text = $"Points: {points}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            Random rand = new Random();
            Point p = new Point(rand.Next(maxX), rand.Next(maxY));
            button1.Location = p;
        }
    }
}

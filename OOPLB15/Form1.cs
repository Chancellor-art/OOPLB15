namespace OOPLB15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void áåðñåðêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f0 = new Form2("photo_2022-04-13_01-42-47.jpg", "Áåðñåðê", true);
            f0.ShowDialog();
        }

        private void ìåìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2("photo_2022-04-13_01-49-11.jpg", "Ìåì", true);
            f1.ShowDialog();
        }

        private void ï³êñåëüÀðòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("photo_2022-04-13_01-49-16.jpg", "Ï³êñåëü àðò", true);
            f2.ShowDialog();
        }
    }
}
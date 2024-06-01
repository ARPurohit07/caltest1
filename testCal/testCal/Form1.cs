namespace testCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add();
            Add(float.Parse(txt1.Text.ToString()), float.Parse(txt2.Text.ToString()));
        }

        void Add()
        {
            float a = float.Parse(txt1.Text.ToString());
            float b = float.Parse(txt2.Text.ToString());
            float result = a + b;
            txtResult.Text = result.ToString();
        }

        void Add(float a, float b)
        {
            float result = a + b;
            txtResult.Text = result.ToString();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

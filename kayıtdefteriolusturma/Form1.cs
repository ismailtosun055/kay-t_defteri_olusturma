namespace kayıtdefteriolusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label21.Text = checkBox5.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox6.Items.Add(comboBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(label17.Text + " " +label18.Text+" "+label19.Text+" "+label20.Text+" "+label21.Text+" "+label22.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text=checkBox1.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text=checkBox4.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text=checkBox3.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label19.Text=checkBox2.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = checkBox6.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked= false;
            checkBox2.Checked= false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";

        }
    }
}
namespace Modul3_103022430010
{
    public partial class Form1 : Form
    {
        //int nilaiAwal = Console.ReadLine();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Convert(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Celcius" && comboBox2.SelectedItem == "Farenheit")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (9 / 5) * nilai + 32;
                textBox2.Text = hasil.ToString();
            } 
            else if (comboBox1.SelectedItem == "Celcius" && comboBox2.SelectedItem == "Kelvin")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = nilai + 273;
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Celcius" && comboBox2.SelectedItem == "Reamur")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (4 / 5) * nilai;
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Farenheit" && comboBox2.SelectedItem == "Reamur")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (4 / 9)(nilai - 32);
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Farenheit" && comboBox2.SelectedItem == "Kelvin ")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (5 / 9) * (nilai - 32) + 273;
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Farenheit" && comboBox2.SelectedItem == "Celcius ")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (5 / 9) * (nilai - 32);
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Kelvin" && comboBox2.SelectedItem == "Celcius")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = nilai - 273;
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Kelvin" && comboBox2.SelectedItem == "Reamur")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (4 / 5) * (nilai - 732);
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Kelvin" && comboBox2.SelectedItem == "Farenheit ")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (9 / 5) * (nilai - 273) + 32;
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Reamur" && comboBox2.SelectedItem == "Celcius")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (5 / 4) * nilai;
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Reamur" && comboBox2.SelectedItem == "Kelvin")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = nilai + 273 
                textBox2.Text = hasil.ToString();
            }
            else if (comboBox1.SelectedItem == "Reamur" && comboBox2.SelectedItem == "Farenheit ")
            {
                double nilai = double.Parse(textBox1.Text);
                double hasil = (9 / 4) * (nilai + 32);
                textBox2.Text = hasil.ToString();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
namespace pr15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pocht ad = new Pocht();
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("1.txt"))
            {
                StreamReader sw = File.OpenText("1.txt");
                while (!sw.EndOfStream)
                {
                    string st = sw.ReadLine();
                    listBox1.Items.Add(st);
                }
                sw.Close();
            }
            else
            {
                MessageBox.Show("Файл не существует");
            }
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполните пожауйста пустые поля!!!");
            }
            else
            {
                int indexToSelect = listBox1.SelectedIndex;
                listBox1.SetSelected(indexToSelect, true);
                listBox1.Items[indexToSelect] = $"Улица: {textBox1.Text}, Город: {textBox2.Text}, Область: {textBox3.Text}, Код: {textBox4.Text}";
                string filePath = "1.txt";
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(listBox1.Text))
                    {
                        lines[i] = $"Улица: {textBox1.Text}, Город: {textBox2.Text}, Область: {textBox3.Text}, Код: {textBox4.Text}";
                    }
                }
                File.WriteAllLines(filePath, lines);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            button3.Enabled = true;
        }
    }
}
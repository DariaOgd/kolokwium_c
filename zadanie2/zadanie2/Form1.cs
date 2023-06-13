using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private string GetCategorization(string[] input)
        {
            StringBuilder result = new StringBuilder();

            foreach (string letter in input)
            {
                if (!string.IsNullOrEmpty(letter))
                {
                    string category = GetCategory(letter[0]);
                    result.AppendLine($"{letter} is {category}");
                }
            }

            return result.ToString();
        }
        private string[] SplitIntoCharacters(string input)
        {
            string[] characters = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                characters[i] = input[i].ToString();
            }

            return characters;
        }

        private string GetCategory(char letter)
        {
            letter = char.ToLower(letter);

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return "samog³osk¹\n";
            }
            else
            {
                return "spó³g³osk¹\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string litery = textBox1.Text;
            string[] items = litery.Contains(";") ? litery.Split(';') : SplitIntoCharacters(litery);

            textBox2.Text = GetCategorization(items);
        }


    }
}
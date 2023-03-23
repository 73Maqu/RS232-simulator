using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RS232
{
    public partial class Nadajnik : Form
    {
        public string text;
       
        
        public Nadajnik()
        {
            InitializeComponent();
        }

      
        private void InputText_TextChanged(object sender, EventArgs e) //wykrycie wpsiania tekstu
        {
            text = InputText.Text;
            if (InputText.Text.Equals("")) Convertt.Enabled = false;
            else Convertt.Enabled = true;

        }

        private void OutputText_TextChanged(object sender, EventArgs e) //wykrycie przekonwertowania tekstu
        {
            if (OutputText.Text.Equals("")) Send.Enabled = false;
            else Send.Enabled = true;
        }

        private void Convert_Click(object sender, EventArgs e) //konwertowanie
        {
            OutputText.Text = (String)strToDec(text);
        }

        private void Send_Click(object sender, EventArgs e) //wsysyłanie
        {
            MessageScreen.Text = (String)binToStr(OutputText.Text);
            binary = null;
            message2 = null;
        }

        private void c2_Click(object sender, EventArgs e) //czyszczenie
        {
            InputText.Text = "";
            OutputText.Text = "";
            MessageScreen.Text = "";
        }

        private object strToDec(string text)  //zmiana stringa na binarny
        {
            string[] bannedWords = System.IO.File.ReadAllLines("banned.txt");

            foreach (string banned in bannedWords) //sprawdzanie i cenzurowanie slow zakazanych
            {
                bool isThereBannedWord = text.Contains(banned);
                if (isThereBannedWord)
                {
                    int index = text.IndexOf(banned);
                    if (index >= 0)
                    {
                        text = text.Replace(banned, Censure(banned.Length));
                    }
                }
            }

            byte[] bytes = Encoding.ASCII.GetBytes(text);
            foreach (byte b in bytes)
            {
                data[i] = Convert.ToString(b, 2).PadLeft(8, '0');   
                data_reversed[i] = Reverse(data[i]);
                i++;
            }
            int x = i;
            i = 0;
            for (int j = 0; x > j; j++)
            {
               binary = binary + "0" + data_reversed[j] + "11";     //Dodanie bitów startu i stopu
            }
            return binary;
        }

        private object binToStr(string binary) //zmiana bajtów na string
        {
            int m = 0;
      
   
            for (int i = 0; i < binary.Length; i+=11)
            {
                String substring = binary.Substring(i+1,8);
                message[m] = substring;
                message2 = message2+ Reverse(message[m]);
                m++;

            }
            var data = GetBytesFromBinaryString(message2);
            var text = Encoding.ASCII.GetString((byte[])data);
            return text;
           
        }

        private object GetBytesFromBinaryString(string message2) //odczytanie bajtów
        {
            List<Byte> byteList = new List<Byte>();
            var list = new List<Byte>();
            for (int i = 0; i < message2.Length; i += 8)
            {
                string t = message2.Substring(i, 8);
                list.Add(Convert.ToByte(t,2));
            }
            return list.ToArray();
        }

        public static string Reverse(string s) //odwrócenie
        {
            char[] reversedArray = s.ToCharArray();
            Array.Reverse(reversedArray);
            return new string(reversedArray);
        }

        public static string Censure(int n) //cenzura
        {
            string word = null;
            for (int i = 0; i <= n; i++)
            {
                word += "*";
            }
            return word;
        }
    }


}

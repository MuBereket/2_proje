using System.Diagnostics.Eventing.Reader;

namespace odev2
{
    public partial class Form1 : Form
    {
        readF reader = new readF();
        writeF writer = new writeF();
        public int s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            reader = new readF();
            s = reader.ara(textBox4.Text);
            if (s > -1)
            {
                label5.Text = label1.Text;
                label6.Text = label2.Text;
                label7.Text = label3.Text;

                label8.Text = reader.Adi[s];
                label9.Text = reader.Populasyon[s];
                label10.Text = reader.Length[s];

            }
            else
            {
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                MessageBox.Show("yok!!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Box1.Text.Length == 0 || Box2.Text.Length == 0 || Box3.Text.Length == 0)
            {
                MessageBox.Show("Hata: Alanlar doldurulmamış");
            }
            else
            {
                writer.ekle(Box1.Text, Box2.Text, Box3.Text);
                Box1.Text = "";
                Box2.Text = "";
                Box3.Text = "";
                MessageBox.Show("Başarıyla kaydedildi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0)
            {
                MessageBox.Show("Hata: Alanlar doldurulmamış");
            }
            else
            {
                writer.sil(textBox5.Text);
                if (writer.varmi)
                {
                    label12.Text = "Başarıyla silindi...";
                    textBox5.Text = "";
                }
                else
                {
                    label12.Text = "Silinecek isim mevcut değil!!....";
                    textBox5.Text = "";
                }
            }
        }


        private void Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            writer.guncell(s, textBox7.Text, textBox8.Text, textBox9.Text);
            MessageBox.Show("Başarıyla kaydedildi");
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reader = new readF();
            s = reader.ara(textBox6.Text);
            if (s > -1)
            {

                textBox7.Text = reader.Adi[s];
                textBox8.Text = reader.Populasyon[s];
                textBox9.Text = reader.Length[s];
                textBox6.Text = "";
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;

            }
            else
            {
                textBox6.Text = "";
                MessageBox.Show("yok!!");

            }


        }
    }
}
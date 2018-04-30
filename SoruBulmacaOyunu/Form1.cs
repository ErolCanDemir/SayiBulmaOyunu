using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruBulmacaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown_BasamakSayisi.Enabled = false;
            button_SayiUret.Enabled = false;
            textBox_Onbinler.Enabled = false;
            textBox_Binler.Enabled = false;
            textBox_Yuzler.Enabled = false;
            textBox_Onlar.Enabled = false;
            textBox_Birler.Enabled = false;
            button_Kontrol.Enabled = false;
            radioButton_Tekrarli.Enabled = false;
            radioButton_Tekrarsiz.Enabled = false;
            numericUpDown_Hak.Enabled = false;
            textBox_Ad.MaxLength = 5;
        }
        DialogResult dr = new DialogResult();
        Random rn = new Random();
        int uzunluk;
        int basamaksayisi;
        int[] sayi;
        bool durum;
        int sayac = 10;
        int hak ;
        private void button_Baslat_Click(object sender, EventArgs e)
        {
            basamaksayisi = Convert.ToInt16(numericUpDown_BasamakSayisi.Value);
            uzunluk = textBox_Ad.Text.Length;
            numericUpDown_BasamakSayisi.Maximum = uzunluk;
            numericUpDown_BasamakSayisi.Enabled = true;
            button_SayiUret.Enabled = true;
            radioButton_Tekrarli.Enabled = true;
            radioButton_Tekrarsiz.Enabled = true;
            numericUpDown_Hak.Enabled = true;
        }
        private void button_SayiUret_Click(object sender, EventArgs e)
        {
            hak = Convert.ToInt32(numericUpDown_Hak.Value);
            basamaksayisi = Convert.ToInt16(numericUpDown_BasamakSayisi.Value);
            sayi = new int[basamaksayisi];
               
            if (basamaksayisi == 1)
            {
                MessageBox.Show("Basamak sayısı en az 2 olmalıdır.");
            }
            else if (basamaksayisi == 2)
            {
                textBox_Birler.Enabled = true;
                textBox_Onlar.Enabled = true;
                button_Kontrol.Enabled = true;
                numericUpDown_Hak.Enabled = true;
            }
            else if (basamaksayisi == 3)
            {
                textBox_Birler.Enabled = true;
                textBox_Onlar.Enabled = true;
                textBox_Yuzler.Enabled = true;
                button_Kontrol.Enabled = true;
                numericUpDown_Hak.Enabled = true;
            }
            else if (basamaksayisi == 4)
            {
                textBox_Birler.Enabled = true;
                textBox_Onlar.Enabled = true;
                textBox_Yuzler.Enabled = true;
                textBox_Binler.Enabled = true;
                button_Kontrol.Enabled = true;
                numericUpDown_Hak.Enabled = true;
            }
            else if (basamaksayisi == 5)
            {
                textBox_Birler.Enabled = true;
                textBox_Onlar.Enabled = true;
                textBox_Yuzler.Enabled = true;
                textBox_Binler.Enabled = true;
                textBox_Onbinler.Enabled = true;
                button_Kontrol.Enabled = true;
                numericUpDown_Hak.Enabled = true;
            }
            else
            {
                MessageBox.Show("Basamak sayısı değeri hatalıdır.");
            }
            if (radioButton_Tekrarli.Checked == true)
            {
                for (int i = 0; i < basamaksayisi; i++)
                {
                    sayi[i] = rn.Next(10);
                }
            }
            else if (radioButton_Tekrarsiz.Checked == true)
            {
                int sayi_deneme = rn.Next(10);
                for (int i = 0; i < basamaksayisi; i++)
                {
                    while (durum)
                    {
                        sayi_deneme = rn.Next(10);
                        if (i == 0)
                        {
                            sayi[0] = sayi_deneme;
                            break;
                        }
                        for (int k = 0; k < i; k++)
                        {
                            if (sayi[k] == sayi_deneme)
                            {
                                durum = true;
                                break;
                            }
                            else
                            {
                                durum = false;
                            }
                        }
                        if (durum == false)
                        {
                            sayi[i] = sayi_deneme;
                        }
                    }
                    durum = true;
                }
            }
            else
            {
                MessageBox.Show("Sayının tekrarlı veya tekrarsız olacağını belirtip tekrar deneyiniz...");
                textBox_Onbinler.Enabled = false;
                textBox_Binler.Enabled = false;
                textBox_Yuzler.Enabled = false;
                textBox_Onlar.Enabled = false;
                textBox_Birler.Enabled = false;
                button_SayiUret.Enabled = true;
            }
            button_SayiUret.Enabled = false;
            button_Baslat.Enabled = false;
            textBox_Ad.Enabled = false;
            numericUpDown_BasamakSayisi.Enabled = false;
            timer1.Start();
        }
        private void button_Kontrol_Click(object sender, EventArgs e)
        {

            if (basamaksayisi == 1)
            {
                if (Convert.ToInt32(textBox_Birler.Text) == sayi[0])
                {
                    MessageBox.Show("Birler Basamağındaki Sayı ve Yeri Doğru");
                    label6.BackColor = Color.Blue;
                    timer1.Stop();
                }
            }
            else if (basamaksayisi == 2)
            {
                if (textBox_Birler.Text == sayi[0].ToString() && textBox_Onlar.Text == sayi[1].ToString())
                {
                    MessageBox.Show("TEBRİKLER SAYIYI DOĞRU BİLDİNİZ...");
                    label5.BackColor = Color.Blue;
                    label6.BackColor = Color.Blue;
                    timer1.Stop();
                }
                if (Convert.ToInt32(textBox_Birler.Text) == sayi[1])
                {
                    MessageBox.Show("Birler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label6.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Birler.Text) == sayi[0])
                {
                    MessageBox.Show("Birler Basamağındaki Sayı ve Yeri Doğru");
                    label6.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Birler Basamağındaki Rakam Sayıda yoktur.");
                    label6.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(textBox_Onlar.Text) == sayi[0])
                {
                    MessageBox.Show("Onlar Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label5.BackColor = Color.Red;
                }

                else if (Convert.ToInt32(textBox_Onlar.Text) == sayi[1])
                {
                    MessageBox.Show("Onlar Basamağındaki Sayı ve Yeri Doğru");
                    label5.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Onlar Basamağındaki Rakam Sayıda yoktur.");
                    label5.BackColor = Color.Yellow;
                }
            }
            else if (basamaksayisi == 3)
            {
                if (textBox_Birler.Text == sayi[0].ToString() && textBox_Onlar.Text == sayi[1].ToString() && textBox_Yuzler.Text == sayi[2].ToString())
                {
                    MessageBox.Show("TEBRİKLER SAYIYI DOĞRU BİLDİNİZ...");
                    label4.BackColor = Color.Blue;
                    label5.BackColor = Color.Blue;
                    label6.BackColor = Color.Blue;
                    timer1.Stop();
                }
                if (Convert.ToInt32(textBox_Birler.Text) == sayi[1] || Convert.ToInt32(textBox_Birler.Text) == sayi[2])
                {
                    MessageBox.Show("Birler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label6.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Birler.Text) == sayi[0])
                {
                    MessageBox.Show("Birler Basamağındaki Sayı ve Yeri Doğru");
                    label6.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Birler Basamağındaki Rakam Sayıda yoktur.");
                    label6.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(textBox_Onlar.Text) == sayi[0] || Convert.ToInt32(textBox_Onlar.Text) == sayi[2])
                {
                    MessageBox.Show("Onlar Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label5.BackColor = Color.Red;
                }

                else if (Convert.ToInt32(textBox_Onlar.Text) == sayi[1])
                {
                    MessageBox.Show("Onlar Basamağındaki Sayı ve Yeri Doğru");
                    label5.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Onlar Basamağındaki Rakam Sayıda yoktur.");
                    label5.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(textBox_Yuzler.Text) == sayi[0] || Convert.ToInt32(textBox_Yuzler.Text) == sayi[1])
                {
                    MessageBox.Show("Yüzler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label4.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Yuzler.Text) == sayi[2])
                {
                    MessageBox.Show("Yüzler Basamağındaki Sayı ve Yeri Doğru");
                    label4.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Yüzler Basamağındaki Rakam Sayıda yoktur.");
                    label4.BackColor = Color.Yellow;
                }
            }
            else if (basamaksayisi == 4)
            {
                if (textBox_Birler.Text == sayi[0].ToString() && textBox_Onlar.Text == sayi[1].ToString() && textBox_Yuzler.Text == sayi[2].ToString() && textBox_Binler.Text == sayi[3].ToString())
                {
                    MessageBox.Show("TEBRİKLER SAYIYI DOĞRU BİLDİNİZ...");
                    label3.BackColor = Color.Blue;
                    label4.BackColor = Color.Blue;
                    label5.BackColor = Color.Blue;
                    label6.BackColor = Color.Blue;
                    timer1.Stop();
                }
                if (Convert.ToInt32(textBox_Birler.Text) == sayi[1] || Convert.ToInt32(textBox_Birler.Text) == sayi[2] || Convert.ToInt32(textBox_Birler.Text) == sayi[3])
                {
                    MessageBox.Show("Birler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label6.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Birler.Text) == sayi[0])
                {
                    MessageBox.Show("Birler Basamağındaki Sayı ve Yeri Doğru");
                    label6.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Birler Basamağındaki Rakam Sayıda yoktur.");
                    label6.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(textBox_Onlar.Text) == sayi[0] || Convert.ToInt32(textBox_Onlar.Text) == sayi[2] || Convert.ToInt32(textBox_Onlar.Text) == sayi[3])
                {
                    MessageBox.Show("Onlar Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label5.BackColor = Color.Red;
                }

                else if (Convert.ToInt32(textBox_Onlar.Text) == sayi[1])
                {
                    MessageBox.Show("Onlar Basamağındaki Sayı ve Yeri Doğru");
                    label5.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Onlar Basamağındaki Rakam Sayıda yoktur.");
                    label5.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(textBox_Yuzler.Text) == sayi[0] || Convert.ToInt32(textBox_Yuzler.Text ) == sayi[1] || Convert.ToInt32(textBox_Yuzler.Text) == sayi[3])
                {
                    MessageBox.Show("Yüzler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label4.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Yuzler.Text) == sayi[2])
                {
                    MessageBox.Show("Yüzler Basamağındaki Sayı ve Yeri Doğru");
                    label4.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Yüzler Basamağındaki Rakam Sayıda yoktur.");
                    label4.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(textBox_Binler.Text) == sayi[0] || Convert.ToInt32(textBox_Binler.Text) == sayi[1] || Convert.ToInt32(textBox_Binler.Text) == sayi[2])
                {
                    MessageBox.Show("Binler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label3.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Binler.Text) == sayi[3])
                {
                    MessageBox.Show("Binler Basamağındaki Sayı ve Yeri Doğru");
                    label3.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Binler Basamağındaki Rakam Sayıda yoktur.");
                    label3.BackColor = Color.Yellow;
                }
            }


            else if (basamaksayisi == 5)
            {


                if (textBox_Birler.Text == sayi[0].ToString() && textBox_Onlar.Text == sayi[1].ToString() && textBox_Yuzler.Text == sayi[2].ToString() && textBox_Binler.Text == sayi[3].ToString() && textBox_Onbinler.Text == sayi[4].ToString())
                {
                    MessageBox.Show("TEBRİKLER SAYIYI DOĞRU BİLDİNİZ...");
                    label2.BackColor = Color.Blue;
                    label3.BackColor = Color.Blue;
                    label4.BackColor = Color.Blue;
                    label5.BackColor = Color.Blue;
                    label6.BackColor = Color.Blue;
                    timer1.Stop();
                }


                if (Convert.ToInt32(textBox_Birler.Text) == sayi[1] || Convert.ToInt32(textBox_Birler.Text) == sayi[2] || Convert.ToInt32(textBox_Birler.Text) == sayi[3] || Convert.ToInt32(textBox_Birler.Text) == sayi[4])
                {
                    MessageBox.Show("Birler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label6.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Birler.Text) == sayi[0])
                {
                    MessageBox.Show("Birler Basamağındaki Sayı ve Yeri Doğru");
                    label6.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Birler Basamağındaki Rakam Sayıda yoktur.");
                    label6.BackColor = Color.Yellow;
                }


                if (Convert.ToInt32(textBox_Onlar.Text) == sayi[0] || Convert.ToInt32(textBox_Onlar.Text) == sayi[2] || Convert.ToInt32(textBox_Onlar.Text) == sayi[3] || Convert.ToInt32(textBox_Onlar.Text) == sayi[4])
                {
                    MessageBox.Show("Onlar Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label5.BackColor = Color.Red;
                }

                else if (Convert.ToInt32(textBox_Onlar.Text) == sayi[1])
                {
                    MessageBox.Show("Onlar Basamağındaki Sayı ve Yeri Doğru");
                    label5.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Onlar Basamağındaki Rakam Sayıda yoktur.");
                    label5.BackColor = Color.Yellow;
                }


                if (Convert.ToInt32(textBox_Yuzler.Text) == sayi[0] || Convert.ToInt32(textBox_Yuzler.Text) == sayi[1] || Convert.ToInt32(textBox_Yuzler.Text) == sayi[3] || Convert.ToInt32(textBox_Yuzler.Text) == sayi[4])
                {
                    MessageBox.Show("Yüzler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label4.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Yuzler.Text) == sayi[2])
                {
                    MessageBox.Show("Yüzler Basamağındaki Sayı ve Yeri Doğru");
                    label4.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Yüzler Basamağındaki Rakam Sayıda yoktur.");
                    label4.BackColor = Color.Yellow;
                }


                if (Convert.ToInt32(textBox_Binler.Text) == sayi[0] || Convert.ToInt32(textBox_Binler.Text) == sayi[1] || Convert.ToInt32(textBox_Binler.Text) == sayi[2] || Convert.ToInt32(textBox_Binler.Text) == sayi[4])
                {
                    MessageBox.Show("Binler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label3.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Binler.Text) == sayi[3])
                {
                    MessageBox.Show("Binler Basamağındaki Sayı ve Yeri Doğru");
                    label3.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Binler Basamağındaki Rakam Sayıda yoktur.");
                    label3.BackColor = Color.Yellow;
                }

                if (Convert.ToInt32(textBox_Onbinler.Text) == sayi[0] || Convert.ToInt32(textBox_Onbinler.Text) == sayi[1] || Convert.ToInt32(textBox_Onbinler.Text) == sayi[2] || Convert.ToInt32(textBox_Onbinler.Text) == sayi[3])
                {
                    MessageBox.Show("On Binler Basamağındaki Rakam Sayıda Var Ama  Yeri Yanlış");
                    label2.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(textBox_Onbinler.Text) == sayi[4])
                {
                    MessageBox.Show("On Binler Basamağındaki Sayı ve Yeri Doğru");
                    label2.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Binler Basamağındaki Rakam Sayıda yoktur.");
                    label2.BackColor = Color.Yellow;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label7.Text = sayac.ToString();
            label8.Text = hak.ToString();
            if(sayac == 0)
            {
                MessageBox.Show("Belirtilen Sürede Sayıyı Tahmin Edemediniz.");
                sayac = 10;
                hak--;
                if (hak == 0)
                {
                    MessageBox.Show("Son Hakkınızda Bitmiştir. Tekrar Deneyiniz."  );
                    dr = MessageBox.Show("Tekrar Denemek istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo);
                    timer1.Stop();
                    label8.Text = 0.ToString();
                    label7.Text = "0";
                    if(dr == DialogResult.Yes)
                    {
                        numericUpDown_BasamakSayisi.Enabled = true;
                        button_SayiUret.Enabled = true;
                        radioButton_Tekrarli.Enabled = true;
                        radioButton_Tekrarsiz.Enabled = true;
                        numericUpDown_Hak.Enabled = true;
                        textBox_Birler.Clear();
                        textBox_Onlar.Clear();
                        textBox_Yuzler.Clear();
                        textBox_Binler.Clear();
                        textBox_Onbinler.Clear();
                        label2.BackColor = Color.Yellow;
                        label3.BackColor = Color.Yellow;
                        label4.BackColor = Color.Yellow;
                        label5.BackColor = Color.Yellow;
                        label6.BackColor = Color.Yellow;
                        sayac = 10;
                    }
                    else
                    {
                        numericUpDown_BasamakSayisi.Enabled = false;
                        button_SayiUret.Enabled = false;
                        textBox_Onbinler.Enabled = false;
                        textBox_Binler.Enabled = false;
                        textBox_Yuzler.Enabled = false;
                        textBox_Onlar.Enabled = false;
                        textBox_Birler.Enabled = false;
                        button_Kontrol.Enabled = false;
                        radioButton_Tekrarli.Enabled = false;
                        radioButton_Tekrarsiz.Enabled = false;
                        numericUpDown_Hak.Enabled = false;
                        this.Close();
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz...\n Oyunumuzun mantığı seçtiğiniz bilgilere göre bilgisayarın ürettiği sayıyı tahmin etmek ve bulmaktır.\n İlk olarak adınızı giriyorsunuz.\n Daha sonra en fazla adınızın uzunluğu ve en az 2 basamaklı olmak üzere basamak sayısı seçiyorsunuz. \n Daha sonra bilgisayarın ürettiği sayının tekrarlı olabileceğini veya olmayabileceğini seçiyorsunuz.\n En son en az 1 ve en fazla 10 olmak üzere size tanınmasını istediğiniz hakkı seçip Sayı Üret butonuna basarak oyunu başlatıyorsunuz. Her hakkınız için 10 saniyeniz vardır.\n Eğer sayı ve yeri doğruysa mavi, sayı doğru yeri farklıysa kırmızı, sayı yoksa sarı renk olarak kalmaktadır. Bol Şans... :)");
        }
    }
}
   

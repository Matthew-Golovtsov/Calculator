using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string d; //объяквление переменной, которая отвечает за действие (оператор)
        public string n1; // объявление переменной, которая отвечает на первое число 
        public bool n2; // объявление переменной, которая отвечает на второе число 
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";

            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            d = B.Text;
            n1 = textBox1.Text;
            n2 = true;
        }

        private void button16_Click(object sender, EventArgs e) 
        {
            double dn1, dn2, res;               // объявляем переменные .
            res = 0;                            // присваиваем переменной res значение нуля ибо без этого переход в стринг работать не будет.
            dn1 = Convert.ToDouble(n1);         // конвертируем переменную dn1 из int в double.
            dn2 = Convert.ToDouble(textBox1.Text);  // конвертируем переменную dn2 из int в double.
            if (d == "+")                       // если мы нажимаем на оператор "+" (кнопку) то происходит сложение.
            {
                res = dn1 + dn2;
            }
            if (d == "-")                       // если мы нажимаем на оператор "-" (кнопку) то происходит вычитание.
            {
                res = dn1 - dn2;                
            }
            if (d == "x")                       // если мы нажимаем на оператор "x" (кнопку) то происходит умножение.
            {
                res = dn1 * dn2;
            }
            if (d == "%")                       // если мы нажимаем на оператор "%" (кнопку) то происходит вычисление процента от числа.
            {
                res = dn1 * dn2 / 100;
            }
            if (d == "/")                       // если мы нажимаем на оператор "/" (кнопку) то происходит деление.
            {
                res = dn1 / dn2;
            }   
            

            d = "=";                           /* Присваиваем переменной d значение "=" что бы калькулятор не работал раньше времени,
                                                                            а только после того, как мы нажмем на кнопку равенства. */
            n2 = true;                         
            textBox1.Text = res.ToString();    // Конвертируем полученные данные в string что бы их можно было записать в строку.



        }

        private void button18_Click(object sender, EventArgs e)
        {
            double dn, res;                         // объявление переменных
            dn = Convert.ToDouble(textBox1.Text);   // конвертируем оператор в double
            res = Math.Sqrt(dn);                    // присваиваем результату математическую функцию "возведение числа в корень"
            textBox1.Text = res.ToString();         // выводим в поле текстбокса
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double dn, res;                         // объявление переменных
            dn = Convert.ToDouble(textBox1.Text);   // конвертируем оператор в double
            res = Math.Pow(dn, 2);                  // присваваем результату математическую функцию, которая возводит число в степень двойки
            textBox1.Text = res.ToString();         // выводим в поле текстбокса
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dn, res;                         // объявление переменных
            dn = Convert.ToDouble(textBox1.Text);   // конвертируем оператор в double
            res = -dn;                              // присваиваем оператору отрицательный знак
            textBox1.Text = res.ToString();         // выводим в поле текстбокса
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))        // если в поле уже есть "," то больше мы поставить не сможем

                textBox1.Text = textBox1.Text + ","; // если же поле пустое, то разрешается вписать запятую 
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); // убираем от всей длины поля одно значение
            if (textBox1.Text == "")                                              // если в поле нет знаков то,
                textBox1.Text = "0";                                              // присваиваем полю значение "0"
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn, res;                         // объявление переменных
            dn = Convert.ToDouble(textBox1.Text);   // конвертируем оператор в double
            res = Math.Log(dn, 2);                  // присваиваем результату математическую функцию "Логарифм"
            textBox1.Text = res.ToString();         // выводим в поле текстбокса
        }


        private void button23_Click(object sender, EventArgs e)
        {
            double dn, res;                          // объявление переменных
            dn = Convert.ToDouble(textBox1.Text);    // конвертируем оператор в double
            res = Math.Abs(dn);                      // присваиваем результату математическую функцию "модуль"
            textBox1.Text = res.ToString();          // выводим в поле текстбокса

        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a, b, c, q, w, p, r, t, y, aa, bb, cc, qq, ww, pp, rr, tt, yy; // инициализируем оргромнейшее кол-во переменных
            a = Convert.ToInt32(textBox28.Text);
            b = Convert.ToInt32(textBox25.Text);
            c = Convert.ToInt32(textBox21.Text);
            q = Convert.ToInt32(textBox27.Text);
            w = Convert.ToInt32(textBox24.Text);
            p = Convert.ToInt32(textBox22.Text);
            r = Convert.ToInt32(textBox26.Text);
            t = Convert.ToInt32(textBox23.Text);
            y = Convert.ToInt32(textBox20.Text);
            aa = Convert.ToInt32(textBox10.Text);       // каждую переменную присваиваем к нужному textbox'y
            bb = Convert.ToInt32(textBox7.Text);
            cc = Convert.ToInt32(textBox3.Text);
            qq = Convert.ToInt32(textBox9.Text);
            ww = Convert.ToInt32(textBox6.Text);
            pp = Convert.ToInt32(textBox4.Text);
            rr = Convert.ToInt32(textBox8.Text);
            tt = Convert.ToInt32(textBox5.Text);
            yy = Convert.ToInt32(textBox2.Text);
            textBox28.Text = "";
            textBox25.Text = "";
            textBox21.Text = "";
            textBox27.Text = "";
            textBox24.Text = "";
            textBox22.Text = "";
            textBox26.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            textBox23.Text = "";
            textBox20.Text = "";
            textBox10.Text = "";
            textBox7.Text = "";
            textBox3.Text = "";
            textBox9.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            textBox8.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            a = a - aa;
            b = b - bb;
            c = c - cc;
            q = q - qq;
            w = w - ww;                                 
            p = p - pp;
            r = r - rr;
            t = t - tt;
            y = y - yy;
            label1.Text = Convert.ToString(a);    // конвертируем результат в string
            label2.Text = Convert.ToString(b);
            label3.Text = Convert.ToString(c);
            label4.Text = Convert.ToString(q);
            label5.Text = Convert.ToString(w);
            label6.Text = Convert.ToString(p);
            label7.Text = Convert.ToString(r);
            label8.Text = Convert.ToString(t);
            label9.Text = Convert.ToString(y);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int a, b, c, q, w, p, r, t, y, aa, bb, cc, qq, ww, pp, rr, tt, yy;  // инициализируем оргромнейшее кол-во переменных
            a = Convert.ToInt32(textBox28.Text);
            b = Convert.ToInt32(textBox25.Text);
            c = Convert.ToInt32(textBox21.Text);
            q = Convert.ToInt32(textBox27.Text);
            w = Convert.ToInt32(textBox24.Text);
            p = Convert.ToInt32(textBox22.Text);
            r = Convert.ToInt32(textBox26.Text);
            t = Convert.ToInt32(textBox23.Text);
            y = Convert.ToInt32(textBox20.Text);
            aa = Convert.ToInt32(textBox10.Text);   // каждую переменную присваиваем к нужному textbox'y
            bb = Convert.ToInt32(textBox7.Text);
            cc = Convert.ToInt32(textBox3.Text);
            qq = Convert.ToInt32(textBox9.Text);
            ww = Convert.ToInt32(textBox6.Text);
            pp = Convert.ToInt32(textBox4.Text);
            rr = Convert.ToInt32(textBox8.Text);
            tt = Convert.ToInt32(textBox5.Text);
            yy = Convert.ToInt32(textBox2.Text);
            textBox28.Text = "";
            textBox25.Text = "";
            textBox21.Text = "";
            textBox27.Text = "";
            textBox24.Text = "";
            textBox22.Text = "";
            textBox26.Text = "";
            textBox23.Text = "";
            textBox20.Text = "";
            textBox10.Text = "";                    // к каждому textbox'у присваиваем пустое значение
            textBox7.Text = "";
            textBox3.Text = "";
            textBox9.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            textBox8.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            a = a + aa;
            b = b + bb;
            c = c + cc;
            q = q + qq;
            w = w + ww;
            p = p + pp;
            r = r + rr;
            t = t + tt;
            y = y + yy;
            label1.Text = Convert.ToString(a);
            label2.Text = Convert.ToString(b);  // конвертируем результат в string
            label3.Text = Convert.ToString(c);
            label4.Text = Convert.ToString(q);
            label5.Text = Convert.ToString(w);
            label6.Text = Convert.ToString(p);
            label7.Text = Convert.ToString(r);
            label8.Text = Convert.ToString(t);
            label9.Text = Convert.ToString(y);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            int a, b, c, q, w, p, r, t, y, aa, bb, cc, qq, ww, pp, rr, tt, yy, z, x, v, n, m, l, k, j, g; // инициализируем оргромнейшее кол-во переменных
            a = Convert.ToInt32(textBox28.Text);        // каждую переменную присваиваем к нужному textbox'y
            b = Convert.ToInt32(textBox25.Text);        // каждую переменную присваиваем к нужному textbox'y
            c = Convert.ToInt32(textBox21.Text);        // каждую переменную присваиваем к нужному textbox'y
            q = Convert.ToInt32(textBox27.Text);        // каждую переменную присваиваем к нужному textbox'y
            w = Convert.ToInt32(textBox24.Text);        // каждую переменную присваиваем к нужному textbox'y
            p = Convert.ToInt32(textBox22.Text);        // каждую переменную присваиваем к нужному textbox'y
            r = Convert.ToInt32(textBox26.Text);        // каждую переменную присваиваем к нужному textbox'y
            t = Convert.ToInt32(textBox23.Text);        // каждую переменную присваиваем к нужному textbox'y
            y = Convert.ToInt32(textBox20.Text);        // каждую переменную присваиваем к нужному textbox'y
            aa = Convert.ToInt32(textBox10.Text);       // каждую переменную присваиваем к нужному textbox'y
            bb = Convert.ToInt32(textBox7.Text);        // каждую переменную присваиваем к нужному textbox'y 
            cc = Convert.ToInt32(textBox3.Text);        // каждую переменную присваиваем к нужному textbox'y
            qq = Convert.ToInt32(textBox9.Text);        // каждую переменную присваиваем к нужному textbox'y
            ww = Convert.ToInt32(textBox6.Text);        // каждую переменную присваиваем к нужному textbox'y
            pp = Convert.ToInt32(textBox4.Text);        // каждую переменную присваиваем к нужному textbox'y
            rr = Convert.ToInt32(textBox8.Text);        // каждую переменную присваиваем к нужному textbox'y
            tt = Convert.ToInt32(textBox5.Text);        // каждую переменную присваиваем к нужному textbox'y
            yy = Convert.ToInt32(textBox2.Text);        // каждую переменную присваиваем к нужному textbox'y
            textBox28.Text = "";                        // к каждому textbox'у присваиваем пустое значение 
            textBox25.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox21.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox27.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox24.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox22.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox26.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox23.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox20.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox10.Text = "";                        // к каждому textbox'у присваиваем пустое значение
            textBox7.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            textBox3.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            textBox9.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            textBox6.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            textBox4.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            textBox8.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            textBox5.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            textBox2.Text = "";                         // к каждому textbox'у присваиваем пустое значение
            z = a * aa + q * bb + r * cc;   // тут мы присваиваем переменной z умноженные числа из полей, которые мы создали выше (textbox)
            x = b * aa + w * bb + t * cc;   // тут мы присваиваем переменной x умноженные числа из полей, которые мы создали выше (textbox)
            v = c * aa + p * bb + y * cc;   // тут мы присваиваем переменной v умноженные числа из полей, которые мы создали выше (textbox)
            n = a * qq + q * ww + r * pp;   // тут мы присваиваем переменной n умноженные числа из полей, которые мы создали выше (textbox)
            m = b * qq + w * ww + t * pp;   // тут мы присваиваем переменной m умноженные числа из полей, которые мы создали выше (textbox)
            l = c * qq + p * ww + y * pp;   // тут мы присваиваем переменной l умноженные числа из полей, которые мы создали выше (textbox)
            k = a * rr + q * tt + r * yy;   // тут мы присваиваем переменной k умноженные числа из полей, которые мы создали выше (textbox)
            j = b * rr + w * tt + t * yy;   // тут мы присваиваем переменной j умноженные числа из полей, которые мы создали выше (textbox)
            g = c * rr + p * tt + y * yy;   // тут мы присваиваем переменной g умноженные числа из полей, которые мы создали выше (textbox)
            label1.Text = Convert.ToString(z);  //конвертируем результат, который получили в string
            label2.Text = Convert.ToString(x);  //конвертируем результат, который получили в string
            label3.Text = Convert.ToString(v);  //конвертируем результат, который получили в string
            label4.Text = Convert.ToString(n);  //конвертируем результат, который получили в string
            label5.Text = Convert.ToString(m);  //конвертируем результат, который получили в string
            label6.Text = Convert.ToString(l);  //конвертируем результат, который получили в string
            label7.Text = Convert.ToString(k);  //конвертируем результат, который получили в string
            label8.Text = Convert.ToString(j);  //конвертируем результат, который получили в string
            label9.Text = Convert.ToString(g);  //конвертируем результат, который получили в string
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            string path = @"D:\Sohr"; //Выполняет операции для экземпляров класса String, содержащих сведения о пути к файлу или каталогу. 
            DirectoryInfo dirinfo = new DirectoryInfo(path);    //Предоставляет методы экземпляра класса для создания, 
                                                            //перемещения и перечисления в каталогах и подкаталогах
            if (!dirinfo.Exists)         //Определяет, существует ли заданный файл.
            {
                dirinfo.Create();        //если файла нет, то создаёт его
            }
            string text = textBox1.Text; // присваиваем textbox1.Text переменной text
            using (FileStream fstream = new FileStream(@"D:\Sohr\res.txt", FileMode.OpenOrCreate)) 
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);   // декодируем 
                fstream.Write(array, 0, array.Length);                        // вписывает данные в файл
         
            }
                using(FileStream fstream = File.OpenRead(@"D:\Sohr\res.txt")) // открывает и читает "сохраненный" файл 
            {
                
                byte[] array = new byte[fstream.Length];                      //преобразуем строку в байты

                fstream.Read(array, 0, array.Length);                         // считываем данные
                
                string textFromFile = System.Text.Encoding.Default.GetString(array);    // декодируем байты в строку
                label11.Text = textFromFile;
                
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
          

            }
        }
    }
   }


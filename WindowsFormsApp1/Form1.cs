using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinearAlgorithm();
        }

        void LinearAlgorithm()
        {
            double a; //переменная для хранения результата
            double x, y, z; //переменные для вычисления в алгоритме
            x = double.Parse(linX.Text); //Здесь берутся значения из соответсвующих полей на форме
            y = double.Parse(linY.Text);
            z = double.Parse(linZ.Text);
            
            //Здесь происходит вычисление линейного алгоритма
            a = Math.Log(Math.Pow(y, -Math.Sqrt(Math.Abs(x)))) * (x - y / 2) + Math.Pow(Math.Sin(Math.Atan(z)), 2); 
            linResult.Text = $"Результат равен {a}"; //Вывод результата в текстовое поле
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeAlgorithm();
        }

        void TreeAlgorithm()
        {
            double k = 0; //Переменная для хранения результата 
            double x, y; //Переменные для подсчёта

            x = double.Parse(treeX.Text); //Берём переменные из соответствующих полей
            y = double.Parse(treeY.Text);

            //Здесь проверяем на нажатие радиоКнопки и получаем её в качестве объекта
            RadioButton rdBtn = this.groupBox1.Controls.OfType<RadioButton>()
                                                    .Where(z => z.Checked).FirstOrDefault();
            if(rdBtn != null) //главная проверка на активацию радиоКнопки
            {
                if(x*y > 1 && x*y < 4) //1 условие в функции
                {
                    if(rdBtn.Name == "radioCos") //В зависимости от имени радиоКнопки, используем разные функции для подсчёта
                    {
                        k = Math.Pow( Math.Cos(x) + y, 2);
                    }
                    else if(rdBtn.Name == "radioSqrt")
                    {
                        k = Math.Pow(Math.Sqrt(x) + y, 2);
                    }
                    else
                    {
                        k = Math.Pow(Math.Exp(x) + y, 2);
                    }
                }
                else if(x*y < 10 && x*y > 8) //2 условие в функции
                {
                    if (rdBtn.Name == "radioCos")
                    {
                        k = Math.Cos(x) * Math.Tan(y);
                    }
                    else if (rdBtn.Name == "radioSqrt")
                    {
                        k = Math.Sqrt(x) * Math.Tan(y);
                    }
                    else
                    {
                        k = Math.Exp(x) * Math.Tan(y);
                    }
                }
                else //И 3 условие
                {
                    if (rdBtn.Name == "radioCos")
                    {
                        k = Math.Cos(x) + y;
                    }
                    else if (rdBtn.Name == "radioSqrt")
                    {
                        k = Math.Sqrt(x) + y;
                    }
                    else
                    {
                        k = Math.Exp(x) + y;
                    }
                }

            }
            else //Если ни одна радиоКнопка не была нажата, то результат будет равен 0, и появится окошко с предупреждением
            {
                MessageBox.Show("Пожалуйста, выберите функцию перед расчётом");
            }

            treeResult.Text = $"Результат равен {k}"; //вывод результата
        }
    }
}

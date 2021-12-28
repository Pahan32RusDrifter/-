using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Использование_бд
{
    public partial class Test : Form
    {
        public static int num;
        RadioButton[,] masRB;
        public Test()
        {
            InitializeComponent();
            masRB = new RadioButton[16, 5]; //создаем двумерный массив для вариантов ответа
            masRB[0, 0] = rbt11;//присваиваем каждому элементу зависимый переключатель (! начиная с 0)
            masRB[0, 1] = rbt12;
            masRB[0, 2] = rbt13;
            masRB[0, 3] = rbt21;
            masRB[0, 4] = rbt22;
            masRB[1, 0] = rbt23;
            masRB[1, 1] = rbt31;
            masRB[1, 2] = rbt32;
            masRB[1, 3] = rbt33;
            masRB[1, 4] = rbt61;
            masRB[2, 0] = rbt62;
            masRB[2, 1] = rbt63;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Rez f3 = new Rez();
                        f3.ShowDialog();

                        f3.lRez1.Text = "Уровень математических способностей низкий";

                        f3.lRez2.Text = "Уровень познаний в истории способностей низкий";

                        f3.lRez3.Text = "Уровень познаний в астрономии способностей высокий";

                        f3.lRez4.Text = "Желание учиться высокое";

                    }
              }
        }

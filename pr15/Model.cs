using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace pr15
{
    internal class Model
    {// блок с данными
        public static string first;
        public static string second;
        public static string result = "";
        public static int indexComboBox = -1;
        public static List<string> dataList = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };


        // блок для обращения к текстовым полям
        public static TextBlock tbResult;

        // блок с бизнес-логикой
        public static int CalculationResult // свойтсво для отображения результата
        {
            set
            {
                double numberFirst = Convert.ToDouble(first);
                double numberSecondly = Convert.ToDouble(second);
                    switch (value)
                    {
                        case 0:
                            tbResult.Text = Convert.ToString(numberFirst + numberSecondly);
                            break;
                        case 1:
                            tbResult.Text = Convert.ToString(numberFirst - numberSecondly);
                            break;
                        case 2:
                            tbResult.Text = Convert.ToString(numberFirst * numberSecondly);
                            break;
                        case 3:
                            if (numberSecondly == 0)
                            {
                                tbResult.Text = "Делить на ноль нельзя";
                            }
                            else
                            {
                                tbResult.Text = Convert.ToString(numberFirst / numberSecondly);
                            }
                            break;
                    }
            }
        }


    }
}

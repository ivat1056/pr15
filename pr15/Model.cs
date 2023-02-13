using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace pr15
{
    internal class Model
    {
        public static string first;
        public static string second;
        public static string result = "";
        public static int indexComboBox = -1;
        public static List<string> dataList = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };



        public static TextBlock tbFirst;
        public static TextBox tbResult;
    }
}

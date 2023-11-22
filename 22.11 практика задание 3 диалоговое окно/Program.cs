using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11_практика_задание_3_диалоговое_окно
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Interaction.InputBox("Введите ваше имя",
                "Ввод имени");
            string age;
            age = Interaction.InputBox("Введите ваш возраст",
                "Ввод возраста");
            string txt = "Имя: " + name + ", Возраст: " + age;
            MessageBox.Show(txt, "Итог.");
        }
    }
}

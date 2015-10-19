using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosOrderSystem
{
    class Program
    {
        //程式起點
        static void Main(string[] args)
        {
            MealData mealData = new MealData();
            StartUpView startUpView = new StartUpView();
            Application.Run(startUpView);
        }
    }
}

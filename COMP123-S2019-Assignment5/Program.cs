using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5
{
    static class Program
    {
        //creating a dictionary(a kind of list)
        public static Dictionary<FormNames, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //creating an instance of the forms dictionary
            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.SPLASH_SCREEN, new SplashScreen());
            Forms.Add(FormNames.START_FORM, new StartForm());
            Forms.Add(FormNames.SELECT_FORM, new SelectForm());
            Forms.Add(FormNames.PRODUCTINFO_FORM, new ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new OrderForm());
            Application.Run(new SplashScreen());
        }
    }
}

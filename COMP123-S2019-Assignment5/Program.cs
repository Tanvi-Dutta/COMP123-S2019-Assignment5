using COMP123_S2019_Assignment5.Models;
using COMP123_S2019_Assignment5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Authors Name: Tanvi
 * StudentID: 301044096
 * App Creation Date: 16/8/2019
 * 
 * **/
namespace COMP123_S2019_Assignment5
{
    public static class Program
    {
        //static members declared
        public static Product product;
        public static SelectForm selectForm;
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;
        public static Hardware hardware;

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //instanciated
            product = new Product();
            selectForm = new SelectForm();
            splashScreen = new SplashScreen();
            startForm = new StartForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();
            hardware = new Hardware();

            Application.Run(splashScreen);
        }
    }
}

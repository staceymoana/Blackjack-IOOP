using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    
    static class Program
    {
        //declare global variable: start menu
        public static Blackjack blackjack;
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            blackjack = new Blackjack();
            //Application.Run(new Blackjack());
            Application.Run(blackjack);
        }
    }


}

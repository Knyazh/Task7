using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Common
{
    public class UpdateLanguagePreferenceCommand
    {
        public static void Handle()
        {
            Console.WriteLine("Dil secimleri:");
            Console.WriteLine("Azerbaijan");
            Console.WriteLine("English");
            Console.WriteLine("Russian");
            while (true)
            {
                string choise = Console.ReadLine();

                if (choise == "Azerbaijan")
                {
                    Console.WriteLine("Xos gelmisiniz");
                    return;
                }

                if (choise =="Russian")
                {

                    Console.WriteLine("добро пожаловать");
                    return; 
                }


                if (choise != null)
                {
                    Console.WriteLine("Duzgun daxil edin");
                    return;
                }

            }


        }
    }
}

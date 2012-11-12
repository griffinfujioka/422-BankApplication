using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication_Csharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            System.ConsoleKeyInfo KInfo;
            BankManager bankApp = new BankManager(); 

            bankApp.runBankApplication(); 


            #region Press Enter to exit...
            Console.WriteLine("Press Enter to exit....");
            KInfo = Console.ReadKey(true);
            while (KInfo.Key.ToString() != "Enter")
            {
                Console.WriteLine("Press Enter to exit...");
                KInfo = Console.ReadKey(true);
            }

            if (KInfo.Key.ToString() == "Enter")
                return;
            #endregion 
        }
    }
}

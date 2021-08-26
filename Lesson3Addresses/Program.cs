using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coder.Shared;

namespace Lesson3Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the address: ");
            string userAddy = Console.ReadLine();

            qrCoder companyAddressCoder = new qrCoder();
            companyAddressCoder.GenerateCode(userAddy);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyObjectos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale();
            Console.WriteLine(sale1.GetInfo());
            Console.WriteLine(sale1.Show());
        }

        public class Sale
        {
            int total;
            DateTime date;

            public string GetInfo()
            {
                return total + ' ' + date.ToLongDateString();
            }

            public string Show()
            {
                return "hola soy una ventana";
            }
        }
    }
}

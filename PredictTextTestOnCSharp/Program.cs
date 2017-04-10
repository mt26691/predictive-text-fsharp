using PredictText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictTextTestOnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var returnedData = PredictiveText.Autocomplete("test", PredictiveText.LoadDict);
            foreach (var data in returnedData)
            {
                Console.WriteLine(data);
            }

            Console.ReadLine();
        }
    }
}

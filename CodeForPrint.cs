using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public static class CodeForPrint
    {
        public static IEnumerable<Indirizzo> Read()
        {
            using var input = File.OpenText("addresses.csv");
            var indirizzi = new List<Indirizzo>();
            input.ReadLine();

            while (true)
            {
                string? line = input.ReadLine();
                if(line is null) return indirizzi;
            }
        }
        public static void Write(IEnumerable<Indirizzo> Indirizzi)
        {
            using var output = File.CreateText("input.csv");

        }
    }
}

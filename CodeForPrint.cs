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
            using var input = File.OpenText("..\\..\\..\\addresses.csv");
            var indirizzi = new List<Indirizzo>();
            input.ReadLine();

            while (true)
            {
                string? line = input.ReadLine();
                if(line is null) return indirizzi;

                var pieces = line.Split(',');

                var name = pieces[0];
                var surname = pieces[1];
                var street = pieces[2];
                var city = pieces[3];
                var province = pieces[4];
                var ZIP = Convert.ToInt32(pieces[5]);

                var indirizzo = new Indirizzo(name, surname, street, city, province, ZIP);

                indirizzi.Add(indirizzo);
            }
        }
        public static void Write(IEnumerable<Indirizzo> Indirizzi)
        {
            using var output = File.CreateText("..\\..\\..\\ouput.csv");

            foreach(var indirizzo in Indirizzi)
            {
                output.WriteLine("{0},{1},{2},{3},{4},{5}", indirizzo.Name, indirizzo.Surname, indirizzo.Street, indirizzo.City, indirizzo.Province, indirizzo.ZIP);
            }
        }
    }
}

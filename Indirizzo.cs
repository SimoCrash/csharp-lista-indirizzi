using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public record Indirizzo
    {

        public Indirizzo(string name, string surname, string street, string city, string province, int ZIP)
        {
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Province = province;
            this.ZIP = ZIP;
        }

        public string Name { get; init; }
        public string Surname { get; init; }
        public string Street { get; init; }
        public string City { get; init; }
        public string Province { get; init; }   
        public int ZIP { get; init; }
    }
}

using csharp_lista_indirizzi;

var indirizzi = Indirizzo.Read();

foreach (var indirizzo in indirizzi)
{
    Console.WriteLine(indirizzo);
}

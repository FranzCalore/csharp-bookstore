// See https://aka.ms/new-console-template for more information
string conferma;
string titolo = "";
string autore = "";
string isbn = "";
int numeroPagine;
int pesoLibro;
double larghezza;
double altezza;
double profondità;
double valutazione;
int numeroRecensioni;
bool isKindle;
bool isFlessibile;
string suKindle = "";
string flessibile = "";
do
{
    Console.WriteLine("Quale è il titolo del Libro?");
    titolo = Console.ReadLine();
    Console.WriteLine("Hai inserito: " + titolo + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è l'autore del Libro?");
    autore = Console.ReadLine();
    Console.WriteLine("Hai inserito: " + autore + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è l'ISBN del Libro?");
    isbn = Console.ReadLine();
    Console.WriteLine("Hai inserito: " + isbn + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è il numero di pagine del Libro?");
    numeroPagine = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Hai inserito: " + numeroPagine + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è il peso del Libro?");
    pesoLibro = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Hai inserito: " + pesoLibro + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è la larghezza del Libro?");
    larghezza = Double.Parse(Console.ReadLine());
    Console.WriteLine("Hai inserito: " + larghezza + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è l'altezza del Libro?");
    altezza = Double.Parse(Console.ReadLine());
    Console.WriteLine("Hai inserito: " + altezza + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è la profondità del Libro?");
    profondità = Double.Parse(Console.ReadLine());
    Console.WriteLine("Hai inserito: " + profondità + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è la valutazione media del Libro?");
    valutazione = Double.Parse(Console.ReadLine());
    Console.WriteLine("Hai inserito: " + valutazione + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Quale è il numero delle recensioni del Libro?");
    numeroRecensioni = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Hai inserito: " + numeroRecensioni + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
do
{
    Console.WriteLine("Il tuo Libro è disponibile in Kindle? (y/n)");
    string kindle = Console.ReadLine();
    if (kindle != "y")
    {
        isKindle = false;
        suKindle = "No";
        Console.WriteLine("Il tuo libro non è presente su Kindle" + "\nConfermi? (y/n)");
        conferma = Console.ReadLine();
    } else
    {
        isKindle = true;
        suKindle = "Sì";
        Console.WriteLine("Il tuo libro è presente su Kindle" + "\nConfermi? (y/n)");
        conferma = Console.ReadLine();
    }
} while (conferma != "y");
do
{
    Console.WriteLine("Il tuo Libro è disponibile in Copertina flessibile? (y/n)");
    string copertinaFlessibile = Console.ReadLine();
    if (copertinaFlessibile != "y")
    {
        isFlessibile = false;
        flessibile = "No";
        Console.WriteLine("Il tuo libro non è disponibile in Copertina Flessibile" + "\nConfermi? (y/n)");
        conferma = Console.ReadLine();
    }
    else
    {
        isFlessibile = true;
        flessibile = "Sì";
        Console.WriteLine("Il tuo libro è disponibile in Copertina Flessibile" + "\nConfermi? (y/n)");
        conferma = Console.ReadLine();
    }
} while (conferma != "y");

Console.WriteLine($"------------ {titolo} di {autore} ----------------");
Console.WriteLine();
Console.WriteLine($"Informazioni generiche: \nISBN: {isbn} \nNumero delle pagine: {numeroPagine}\nPeso del libro: {pesoLibro}\nDimensioni del libro: {larghezza} X {profondità} X {altezza}");
Console.WriteLine();
Console.WriteLine($"Informazioni di Amazon: \nNumero di recensioni: {numeroRecensioni}\nValutazione media: {valutazione}/5\nKindle disponibile: {suKindle}\nCopertina flessibile disponibile: {flessibile}");
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------");
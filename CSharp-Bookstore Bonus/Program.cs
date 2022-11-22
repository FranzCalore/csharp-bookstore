// See https://aka.ms/new-console-template for more information
string conferma;
string titolo = "";
do
{
    Console.WriteLine("Quale è il titolo del Libro?");
    titolo = Console.ReadLine();
    Console.WriteLine("Hai inserito: " + titolo + "\nConfermi? (y/n)");
    conferma = Console.ReadLine();
} while (conferma != "y");
string autore = "Osamu Dazai";
string isbn = "8804755784";
int numeroPagine = 120;
int pesoLibro = 200;
double larghezza = 14.3;
double altezza = 21.2;
double profondità = 1.3;
double valutazione = 4.3;
int numeroRecensioni = 21;
string kindle = "Sì";
string flessibile = "Sì";

Console.WriteLine($"------------ {titolo} di {autore} ----------------");
Console.WriteLine();
Console.WriteLine($"Informazioni generiche: \nISBN: {isbn} \nNumero delle pagine: {numeroPagine}\nPeso del libro: {pesoLibro}\nDimensioni del libro: {larghezza} X {profondità} X {altezza}");
Console.WriteLine();
Console.WriteLine($"Informazioni di Amazon: \nNumero di recensioni: {numeroRecensioni}\nValutazione media: {valutazione}/5\nKindle disponibile: {kindle}\nCopertina flessibile disponibile: {flessibile}");
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------");
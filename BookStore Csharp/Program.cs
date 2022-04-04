string titolo;
string autore;
string isbn;
string kindle;
string CopertinaFlessibile;
double ValMedia = 0.0;





Console.WriteLine("inserisci il titolo");
 titolo=Console.ReadLine();

Console.WriteLine("inserisci l'autore");
 autore=Console.ReadLine();


Console.WriteLine("inserisci l' ISBN");
isbn= Console.ReadLine();


Console.WriteLine("inserisci il numero delle pagine");
int nPagine = int.Parse(Console.ReadLine());



Console.WriteLine("inserisci il peso del libro in kg");
int PesoLibro = int.Parse(Console.ReadLine());


Console.WriteLine("inserisci la lunghezza del libro in cm");
float lunghezza = float.Parse(Console.ReadLine());

Console.WriteLine("inserisci la larghezza del libro in cm");
float larghezza= float.Parse(Console.ReadLine());

Console.WriteLine("inserisci la profondità del libro in cm");
float profondità = float.Parse(Console.ReadLine());

Console.WriteLine("inserisci il numero delle recensioni del libro");
int nrecensioni = int.Parse(Console.ReadLine());

Console.WriteLine("KINDLE DISPONIBILE ? (SI) o (NO) ");
kindle=Console.ReadLine();

Console.WriteLine(" Copertina Flessibile ? (SI) o (NO) ");
CopertinaFlessibile = Console.ReadLine();



ValMedia = nrecensioni * 10 / 100;







Console.WriteLine("---------- IL LIBRO DI OGGI ------------");
Console.WriteLine();
Console.WriteLine(titolo + " " + "di" + " " + autore);
Console.WriteLine();
Console.WriteLine("Informazioni Generiche:");
Console.WriteLine();
Console.WriteLine("ISBN : " +""+isbn);
Console.WriteLine("Numero Pagine :" + "" + nPagine);
Console.WriteLine("Peso : " + "" + PesoLibro+"kg");
Console.WriteLine("Dimensioni Libro (La,Lu,Pr) : " + "" +larghezza+"cm"+"  "+lunghezza+"cm"+"  "+profondità+"cm");
Console.WriteLine();
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine();
Console.WriteLine("Valutazione Media:" + "" + ValMedia + "STELLE");
Console.WriteLine("NUMERO RECENSIONI:"+" "+nrecensioni);
Console.WriteLine("KINDLE:"+""+kindle);
Console.WriteLine("Copertina flessifile:"+""+CopertinaFlessibile);


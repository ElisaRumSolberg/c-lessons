using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace lesson1;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello, World!");

        Console.WriteLine("hei verden!");

var elevName="Elisa";
var elevEttername="Solberg";
var elevFullname= "Elisa Solberg";
var elevNummeret="123";
var ElevFødselDato="23.08.1991";
var ElevAdressa="Øvre Holen 5";


var produkt1=500;
var produkt2=300;
var produkt3=658;
var sum=produkt1+produkt2+produkt3;
Console.WriteLine(sum);

// value types
byte tall =10;
//artabilecek sayilarda int kullanmak daha akillica
double rente=1.6;
double rente = 2;
// float bir deger tanimlandiginda sonuna f eklenmeli
float rente2= 1.8f;
decimal rente3= 1.5m;
// decimal icinde sonuna m ekliyoruz
char kjøn= 'K';
string kjøn2="Kvinne";
string produktName="Samsung S24";
Boolean erDetSalg= true;
*/
//================================================
// String
Console.Write("name: ");
String? name= Console.ReadLine();

Console.Write("ettername: ");
String? ettername= Console.ReadLine();

Console.Write("alder: ");
var alder=Console.ReadLine();

// 1. method
//String melding = name +" "+ ettername+ " er "+alder+ " år gammel" ;

//2. method
// dolar isaterinden sonra cift tirnak acip degiskenleri {} icine yazip digerlerini normal yaziyoruz
string melding= $"{name} {ettername} er{alder} år gammel";


Console.WriteLine(melding);




    }
}

    


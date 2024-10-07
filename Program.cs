using System;

namespace lesson1;

class Program
{
     static void Main()
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
string melding= $"{name} {ettername} er {alder} år gammel";


Console.WriteLine(melding);
 
 //var resultat = melding.Length;

 //var resultat= melding.ToLower();

 // var resultat = melding.ToUpper();

 // var resultat = melding.Trim();

 //var resultat = melding.Split("") [2];
 // "" icine neden bolecegimizi yazariz burada 
 // bosluk ile yaptik istersek , ilede yapariz
 //Split string i diziye donduruyor

 // var resultat = melding[3];

 // var resultat = melding.StartsWith("E");
 // bu string in ne ile basladigini kontrol eder 
 // sonuc true false olur

 //var resultat = melding.EndsWith(".");

 //var resultat = melding.Contains("El");
 // char ve string gonderebiliriz sonuc true false
 //bu sayede arama yapabiliyourz

//var resultat = melding.IndexOf("Elisa");

// yok ise -1 var ise nedere ise onu verir

// var resultat = melding.Substring(10);

// indexden itibaren yazarlar

 //Console.WriteLine(resultat);

 /*
 String kurs= "C# lessons with KodeHode";

var numberOfCharacters=kurs.Length;
System.Console.WriteLine(numberOfCharacters);

var loverCase=kurs.ToLower();
System.Console.WriteLine(loverCase);

var point = kurs.StartsWith('.');
System.Console.WriteLine(" The string starts with '.'  :" + point);

var location = kurs.IndexOf("C#") ;
System.Console.WriteLine("location is : " + location);

var doesItContain = kurs.Contains("C#");
System.Console.WriteLine("Does it contein C# : " + doesItContain);

var updatedString = kurs.Replace("KodeHode","JobLoop");
System.Console.WriteLine(updatedString);
 */


 // DateTime//

DateTime nå = DateTime.Now;
System.Console.WriteLine(nå);
System.Console.WriteLine(nå.Year);
System.Console.WriteLine(nå.Month);
System.Console.WriteLine(nå.Day);
System.Console.WriteLine(nå.DayOfWeek);

DateTime dt= new DateTime(2016,4,21);
System.Console.WriteLine(dt.Year);

DateTime dt2 =dt.AddYears(1);
System.Console.WriteLine(dt2);

var forksj = nå-dt;
System.Console.WriteLine(forksj.TotalDays);
System.Console.WriteLine(forksj.TotalHours);

// ARRAY

String [] names = new String[5];

    }
}


    


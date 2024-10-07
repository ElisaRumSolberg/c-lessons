using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;

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
int num1 =23;
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
/* String
Console.Write("name: ");
String? name= Console.ReadLine();

Console.Write("ettername: ");
String? ettername= Console.ReadLine();

Console.Write("alder: ");
var alder=Console.ReadLine();

// 1. method
//String melding = name +" "+ ettername+ " er "+alder+ " år gammel" ;

//2. method
// dolar isaterinden sonra cift tirnak acip degiskenleri {} icine
// yazip digerlerini normal yaziyoruz
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
/*
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

// burada 5 elemanli bir dizi olusturuyorum

String [] names = new String[5];
names[0] = "Elisa";
names[1]= "Hafsa";
names[2]= "Eva";
names[3]= " Alissa";
names[4]= "Rumeysa";


string[]names2={"Elisa","Hafsa","Eva","Alissa","Rumeysa"};


int [] numbrs ={33,8,55,32,33};


System.Console.WriteLine($"{names[0]} is {numbrs[0]} years old" );
/*
int[,]numbers= new int[2,4];
numbers[0,0]=21;  
numbers[0,1]=04;
numbers[0,2]=20;
numbers[0,3]=16;

numbers[1,0]=23;
numbers[1,1]=08;
numbers[1,2]=19;
numbers[1,3]=91;

int[,] numbers2 = {
    {21,04,20,16},{23,08,19,91}
};

*/
/*
String[] cities = {"Bergen", "Istanbul","Roma","Oslo","London"};
cities[2]="Milano";
cities.SetValue("Ankara",1);
System.Console.WriteLine(cities[2]);
System.Console.WriteLine(cities.GetValue(1));
System.Console.WriteLine(cities.Length); 
//dizinin eleman sayisi

System.Console.WriteLine(Array.IndexOf(cities,"OSlo"));

Array.Sort(cities);
System.Console.WriteLine(cities.GetValue(5));

Array.Clear(cities);
// bu kodu yazdirdigimizda bosluk cikar string oldugu nicin 
// int default olarak 0 gelir
Array.Clear(cities,1,2);
/////////////////////////////////////////////////////////////////

// ===Array Slicing==
String[] cities1 = {"Bergen", "Istanbul","Roma","Oslo","London","Berlin"};

foreach ( var city in cities1) {
    System.Console.WriteLine(city);
}

foreach ( var city in cities1[0..3]) {
    System.Console.WriteLine(city);
}
*/
//cities1[0..3]) 0. ci index dahil 3. index dahil degil
// buna array bolme denir ve range olarak adlandirilir

/****
///// ==== Array practice =====////
String [] students ={"Harry","Marabel","Jess"};
int [] grades={85,72,88};
foreach (var student in students[..2])
{
    System.Console.WriteLine(student );
}

foreach (var grad in grades[..2])
{
    System.Console.WriteLine(grad);
}

System.Console.WriteLine($"The students array has {students.Length} elements");

var not1= grades[0];
var not2= grades[1];
var not3=grades[2];
var average =(not1+not2+not3)/3;
System.Console.WriteLine("students' grade point average: "+average);


var students1 = new String[3];
var grades1 = new int[3];

System.Console.WriteLine("First student's name is");
students1[0]= Console.ReadLine()??"";

System.Console.WriteLine("First student's grade is");
grades1[0]= Convert.ToInt32(Console.ReadLine()??"");

System.Console.WriteLine("Second student's name");
students1[1]= Console.ReadLine()??"";

System.Console.WriteLine("Andre student's grade is");
grades1[1]= Convert.ToInt32(Console.ReadLine()??"");

System.Console.WriteLine("Third student's name");
students1[2]= Console.ReadLine()??"";

System.Console.WriteLine("Third student's grade is");
grades1[2]= Convert.ToInt32(Console.ReadLine()??"");

// yukaridaki kodu donguler ile kolay bir sekilde yapabiliriz

foreach (var student1 in students1)
{
 System.Console.WriteLine(student1);   
}

foreach (var grad1 in grades1)
{
    System.Console.WriteLine(grad1);
}
*/
/////////// LOOP Dongu//////
/// For Loop

for(var i=0; i<=100 ; i++){
    System.Console.Write(i + ", ");
}

var sum=0;
for (var i =1 ;i<=100; i++){
    sum +=i;
    System.Console.WriteLine(sum);
}



    }
}


    


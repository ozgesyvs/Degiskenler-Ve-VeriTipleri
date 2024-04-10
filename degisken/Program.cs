using System;

class Program{

static void Main(string[] args){


Console.WriteLine("merhaba");


string name = null;

string surname;

surname = "mahmut";

DateTime dt = DateTime.Now;


/*DateTime.Now  yazarak
DateTime kütüphanesinden geldiğini
ve o anki tarih ve saati getirir

*/

//DateTime veri tipi tarigi ve saati tutmak için kullanılır



//string ifadeler

string str1  = "";
string str2 = null;
string str3 = string.Empty;

str3 = "özge";
string ad = "özge";
string soyad =  "siyavus";

string tamisim = ad + " " + soyad;



//Değişken Dönüşümleri

string str20 = "20";

int int20 = 20;

string yenideger = str20 + int20.ToString(); //çıktısı 2020

int int21 = int20 + Convert.ToInt32(str20);  //çıktısı 40


int int22 = int20 + int.Parse(str20); //çıktısı 40

//parse stringden dönüşüm için kullanılır  
//stringde sayıdan başka bir ifade varsa hata verir












/*                                       VERİ TİPLERİ                              */


// byte 0-255 arasını tutabilen tam sayı veri tipidir

byte birinci = 5;

Console.WriteLine(birinci);

Console.ReadLine();

/*

byte veri tipinin içinde maxValue ve minValue 
isimli 2 property var bunlar bize byte veri
tipinin en yüksek ve en düşük değerlerini verir
ram bellekte 1 bytelık yer kaplar


*/

byte maxDeger = byte.MaxValue;

byte minDeger = byte.MinValue;

Console.WriteLine(minDeger + maxDeger);

Console.ReadLine();


/*

short veri tipi -32768 ile 32767 arasını tutan
tam sayı bir veri tipidir
maxValue ve minValue property'leri burada da kullanılır
ram de 2 byte yer kaplar

*/


short birinciDegisken = -4533;

Console.WriteLine(birinciDegisken);

Console.ReadLine();


/*

int veri tipi -2.147.483.648 ile 2.147.483.647 
arasını tutan tam sayı veri tipidir
ram bellekte 4 byte yer kaplar

8 bit = 1 byte
1024 byte = 1kb 
1024 kb = 1 mb
1024 mb = 1gb
1024 gb = 1 tb
1024tb = 1pb

*/


int birinciDeger = 150000;

Console.WriteLine(birinciDeger);

Console.ReadLine();




/*

long veri tipi tam sayı veri tipidir
8 byte yer kaplar ram bellekte

*/

int ilkDeger = 150000;

Console.WriteLine(ilkDeger);

Console.ReadLine();


//maxValue - minValue property'leri buradaki tüm veri tiplerinde kullanılır



/*

float veri tipi ondalıklı sayıları tutmak için kullanılan 
veri tipidir 7-8 basamak arası tutabilir
ram bellekte 4byte'lık yer kaplar

*/


float ondalikliSayi =  35.546f;

Console.WriteLine(ondalikliSayi);
Console.ReadLine();

/*

float olr. ondalıklı sayı tanımladıgımızda 
bunu double olr. algıladığı için f anahtar kelimesini
kullanıyoruz 

*/



/*

double veri tipi de ondalıklı sayı tanımlamak için kullanılır
ram bellekte 8 byte yer kaplar
15 basamaklı ondalıklı sayıları da tutabilir

*/


double ondalikliSayi1 = 33432.56446;

Console.WriteLine(ondalikliSayi);
Console.ReadLine();



/*

char veri tipi tek bir karakteri
tutmak için kullanılır
tek tırnak içerisinde tek değer olacak şekilde kullanılır

*/


char karakter = 'e';

char karakter2 = '?';

Console.WriteLine(karakter2);
Console.ReadLine();



/*

string veri tipi metinleri tutmak için kullanılır

çift tırnak ile kullanılır
*/


string isim = "enes";


/*

boolean veri tipi 2 ihtimalin oldugu
yerlerde kullanılır

*/

bool kontrol1 = true;

bool kontrol = false;

bool sonuc = 10>5;

Console.WriteLine(sonuc);
Console.ReadLine();



/*

object veri tipi
tüm veri tiplerindeki değerleri 
içerisinde tutabilir

*/


object a = "enes";
object b = -34.12;
object c = true;
object d = 'd';
object e = 5;




}





}


/* terminale dotnet new console yazarak
boş bir console application'unu oluştururuz

*/

/*

değişken adları rakamla başlayamaz
büyük küçük harf duyarlıdır

aynı kod blogu içinde aynı isimde degisken
birden fazla kez tanımlamaz
(farklı fonksiyonda olsaydı olurdu)
değişken isimlendirmesinde _ kullanılabilir

*/


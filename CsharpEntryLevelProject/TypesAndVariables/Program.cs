// See https://aka.ms/new-console-template for more information




Console.WriteLine("Hello, World!");

char charcter = 'A';

bool condiditon = true; 
int number1 = 10;  //int değerini -2147483648 ile 2147483647 ye kadar 
long number2 = 20; // long int değerinin 2 katı yer kaplar bundan dolayı int sınırlarında bir sayıyı tutacaksan int kullan DAHA BÜYÜKSE long kullan 
short number3 = 30; // buda int değerinin küçük halidir -32768 ile 32767 arasında bir değer tutar 
byte number4 = 255;  // buda 0 ile 255 arası bir değer tutar 
double number5 = 10.5;
decimal number6 = 10.48561865m;//int için long neyse double için  decimal de odur 
var number7 = 7; // var değişkeni tanımladığın sayıya göre type ayarlar mesela var değeri burda int
Console.WriteLine("Number1 is " + number1);
Console.WriteLine("Number2 is " + number2);
Console.WriteLine("Number3 is " + number3);
Console.WriteLine("Number4 is " + number4);
Console.WriteLine("Number5 is " + number5);
Console.WriteLine("Number7 is " + number7);

Console.WriteLine("Condition is " + condiditon);
Console.WriteLine("Character is " + (int)charcter);


enum MyEnum  
{
    Monday , Tuesday , Wendesday , Friday, Saturday, Sunday 
}




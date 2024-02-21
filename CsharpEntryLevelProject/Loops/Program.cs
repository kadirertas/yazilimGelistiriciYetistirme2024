// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Bu kodun okunurluğu aynen şudur 
// i değerine bak  eğer 100 den küçükse süslü parantez içini yap döngüyü bitir ve sayıyı 1 artırıp kontrol edip 
// tekrar dene 
Console.WriteLine("----------------------------------- For Loops ----------------------------------------"); 
for (int i = 0; i < 10; i++)
{

    Console.WriteLine(i);

}
Console.WriteLine("----------------------------------- While Loops ----------------------------------------");

int b = 0;  
//Bunun fordan farkı eğer sen 23. satırdaki gibi bir artma miktarı vermessen koşul doğru olduğu sürece döngü çalışır 
while(b<100)
{

    Console.WriteLine(b);

   b += 2;
}


Console.WriteLine("----------------------------------- Do While Loops ----------------------------------------");
// Bunun while dan tek farkı whilde döngü koşulu false olursa döngüden çıkılır fakat do while döngü koşulu
// false olsada     EN AZ 1 KEZ ÇALIŞIR 

int number = -2; 

do
{
    Console.WriteLine(number);
    number--; 
   
} while (number>=0);


Console.WriteLine("----------------------------------- Foreach Loops ----------------------------------------");
string[] students = new string[3] {"Engin ", "Derin ", "Salih "};
foreach (var student in students)
{
    Console.WriteLine(student);
}


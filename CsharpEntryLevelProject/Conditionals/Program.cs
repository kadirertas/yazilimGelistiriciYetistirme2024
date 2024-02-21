// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var number = 10;
var number2 = 10;
var number3 = 80;
// tek = atama == sayı eiştliği anlamını taşır 

if (number == 10)
{

    Console.WriteLine("Number is Ten ");


}
else if (number == 20)
{

    Console.WriteLine("Number is Twenty ");

}
else
{
    Console.WriteLine("Number is not Ten or Twenty");
}
// alt satırda bulunan özellik tenary operatör olarak bilinir ve ( öncekoşul ? Doğruysa :Yanlışsa  ) şeklinde kullanılır.
Console.WriteLine(number2 == 10 ? "Number is 10" : "Number is not 10 ");


// switch if in düzenli hali gibi bir şeydir fakat if kadar çok kullanılmaz herşey aynı yani mantık açısından  işte  sadece bilmen gereken break komutu oda bitir ve döngüden  bloktan
// çık anlamında kullanılır 
switch (number2)
{
    case 10:
        {

            Console.WriteLine("Number is Ten ");

            break;
        }
    case 20:
        {
            Console.WriteLine("Number is Twenty ");

            break;
        }
    default:
        {
            Console.WriteLine("Number is not Ten or Twenty ");

            break;
        }
}


// Şimdi burda bulunan mantıksal operatörler &&  ve || dir  ve
// &&(ve) operatörü kullanıldığı yerdeki her şartın doğru olmasını ister 
// ||(veya) operatörü ise kullanıldığı yerdeki şartların tek bir tanesini  doğru olması yeterlidir.ı

if (number3 >=0 && number3 <= 100)
{
    if (number3>=0 && number3<=50)
    {
        Console.WriteLine("Number is between 0 -50");

    }
    else if (number3 > 50 && number3<= 100)
    {
        Console.WriteLine("Number is between 50 -100");


    }
}

else if (number3 > 100 && number3 <= 200)
{
    Console.WriteLine("Number is between 100 -200");
}
if (number3 > 200 || number3 <0)
{
    Console.WriteLine("Number is less than 0 or greater than 200 ");
}
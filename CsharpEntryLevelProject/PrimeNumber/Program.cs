

int number = 956243;
int primenumber;
for (int i = 2; i <=number; i++)
{

    primenumber = number % i;


    if (primenumber == 0  && i!=number)
    {
        Console.WriteLine("Verilen " + number + " sayısı " + i + " sayısına tam bölüntüğünden asal değildir ");


        break; 
    }
    else if (i == number)
    {
        Console.WriteLine("Verilen sayı bir asal sayıdır ");    
        break;
    }

}




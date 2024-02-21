// See https://aka.ms/new-console-template for more information







Yazdir(); 
Yazdir();   
Yazdir();
int result = Add(5, 8);
Console.WriteLine("verilen iki sayının toplamı "+ result);
int result2 = Add2(5, 8);
Console.WriteLine("verilen iki sayının toplamı " + result2); 
int result3 = Add2();
Console.WriteLine("verilen iki sayının  default halinin toplamı " + result3);



int number = 65;
int number2=26; 
int result4 = Add3(number,ref number2);
Console.WriteLine(result4);



int result5 = Multiply(65, 20);
Console.WriteLine("verilen iki sayının çarpımı "+ result5);
int result6 = Add4(15,25,35,45,55,65,75,85,95);
Console.WriteLine("verilen sayıların  toplamı " + result6);
// Biz metotları yazılımın bel kemiği olan  " Don't Repeat Yourself" adlı yapıdan dolayı kullanırız. (Bilmeden geldiysen bu yapıyı araştır)
static void Yazdir()
{
    Console.WriteLine("Yazdırma Başarılı");
}

static int Add( int sayi , int sayi2) 
{ 
   int toplam = sayi + sayi2;
     
    return toplam;
}


// metoda tanımlanan parametreler eğer değer alırlarsa metot çağrıldığında değer gelmediği zaman bu değerler default olarak kullanılır 
static int Add2(int sayi=80, int sayi2=50)
{
    int toplam = sayi + sayi2;

    return toplam;
}



 

static int Add3(int number, ref int number2 )
{
    number2 = 20;
    int toplam = number + number2;

    return toplam;
}

//Şimdi diyelim 100 tane sayıyı parametre alan ve toplama yapan bir metot yazmak
//istediğinizde hepsini tek tek tanımlasanız ortalık savaş alanına döner bunu engellemek
//için params keyword ü kullanılır bu şekilde tanımlanan değişken birden fazla değer alabilir  
// bir metot içinde params kullnılırsa bu o metodun son parametresi olur. 
static int Add4(params int[] number)
{

    int toplam = number.Sum(); 

    return toplam;
}
static int Multiply(int number,  int number2)
{
    
    int toplam = number * number2;

    return toplam;
}


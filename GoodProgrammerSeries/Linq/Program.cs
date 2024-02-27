
List<Category> categories = new List<Category>
{

     new Category {CategoryId = 1, CategoryName = "Bilgisayar"},
     new Category {CategoryId = 2, CategoryName = "Telefon"}

};

List<Product> products = new List<Product>
{

     new Product {CategoryId= 1, ProductId=1, ProductName="Victus", QuantitiyPerUnit ="32 Gb Ram", UnintPrice=100000,  UnitStock =5 },

     new Product {CategoryId= 1, ProductId=2, ProductName="Samsung",QuantitiyPerUnit ="16 Gb Ram", UnintPrice=100000,  UnitStock =3 },


     new Product {CategoryId=1 , ProductId=3, ProductName="Monster",QuantitiyPerUnit ="8 Gb Ram", UnintPrice=60000,  UnitStock =2 },
     new Product {CategoryId= 1, ProductId=4, ProductName="Excalibur",QuantitiyPerUnit ="16 Gb Ram", UnintPrice=50000,  UnitStock =15 },
     new Product {CategoryId= 2, ProductId=5, ProductName="Samsung telefon ",QuantitiyPerUnit ="4 Gb Ram", UnintPrice=10000,  UnitStock =0 },
     new Product {CategoryId=2, ProductId=6, ProductName="Apple Telefon ",QuantitiyPerUnit ="4 Gb Ram", UnintPrice=30000,  UnitStock =52 },
};




Console.WriteLine("--------------------------------Algoritmik------------------------------");
foreach (var item in products)
{
    if (item.UnintPrice<80000 && item.UnitStock>3) 
    {
        Console.WriteLine(item.ProductName);
    }
}

Console.WriteLine("--------------------------------Linqs------------------------------");

var result = products.Where(p => p.UnintPrice < 80000 && p.UnitStock>3);
foreach (var item in result)
{
    
        Console.WriteLine(item.ProductName);
   
}

GetProducts(products);



Console.WriteLine("--------------------------------Algoritmik Method------------------------------");
static List<Product> GetProducts (List<Product> products) {
    List<Product> filteredProduct = new List<Product>();
    foreach (var item in products)
    {
        if (item.UnintPrice < 80000 && item.UnitStock > 3)
        {
            filteredProduct.Add(item);
        }
    }
    return filteredProduct;
    
}
Console.WriteLine("--------------------------------Linqs Method------------------------------");
static List<Product> GetProductsLinq(List<Product> products)
{

    return products.Where(p => p.UnintPrice < 80000 && p.UnitStock > 3).ToList();

}







class Product 
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }

    public string ProductName { get; set; }

    public string QuantitiyPerUnit { get; set; }
    public decimal UnintPrice { get; set; }

    public int UnitStock { get; set; }


}

class Category 
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

}
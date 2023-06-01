
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
var products = new List<Product>
{
    new Product {Name = "Trumpet", Price = 1400.55M, ProductTypeId = 1},
    new Product {Name = "Trombone", Price = 1400.53M, ProductTypeId = 1},
    new Product {Name = "Leaves of Grass", Price = 1400.11M, ProductTypeId = 2},
};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
var productTypes = new List<ProductType>
{
    new ProductType {Id = 1, Title = "Brass"},
    new ProductType {Id = 2, Title = "Poem"},
};
//put your greeting here
Console.WriteLine("Hello");
//implement your loop here
string choice = null;
while (choice != "5")
{
    DisplayMenu();
    Console.Write("Please choose an option");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "5":
            break;
        case "1":
            DisplayAllProducts(products, productTypes);
            break;
        case "2":
            DeleteProduct(products, productTypes);
            break;
        case "3":
            AddProduct(products, productTypes);
            break;
        case "4":
            UpdateProduct(products, productTypes);
            break;

    }
}

Console.WriteLine("Goodbye");

void DisplayMenu()
{
    Console.WriteLine(@"1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        var p = products[i];
        var pt = productTypes.First(pt => pt.Id == p.ProductTypeId);
        Console.WriteLine($"{i}: {p.Name}, {p.Price}, {pt.Title}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    var choice = Console.ReadLine();
    products.RemoveAt(int.Parse(choice));
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    var name = Console.ReadLine();
    var price = decimal.Parse(Console.ReadLine());
    var productTypeId = int.Parse(Console.ReadLine());

    products.Add(new Product { Name = name, Price = price, ProductTypeId = productTypeId });
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    var id = int.Parse(Console.ReadLine());
    var name = Console.ReadLine();
    var price = Console.ReadLine();
    var productTypeId = Console.ReadLine();

    var product = products[id];
    product.Name = name.Length > 0 ? name : product.Name;
    product.Price = price.Length > 0 ? decimal.Parse(price) : product.Price;
    product.ProductTypeId = productTypeId.Length > 0 ? int.Parse(productTypeId) : product.ProductTypeId;
}

// don't move or change this!
public partial class Program { }

        var shop = new Shop();

        var phone1 = new Phone { Name = "iPhone", Price = 999, OperatingSystem = "iOS" };
        var phone2 = new Phone { Name = "Samsung", Price = 899, OperatingSystem = "Android" };
        var car1 = new Car { Name = "Mersedec-Benz AMG", Price = 100000, Model = "Gt63s" };
        var car2 = new Car { Name = "BMW", Price = 80000, Model = "M5F90" };
        System.Console.WriteLine("---------------------------------------------------");

        shop.AddProduct(phone1);
        shop.AddProduct(phone2);
        shop.AddProduct(car1);
        shop.AddProduct(car2);

        shop.PrintProductList();

        shop.RemoveProduct(phone2);
        shop.RemoveProduct(car2);
        System.Console.WriteLine("---------------------------------------------------");

        shop.PrintProductList();












public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name},\nPrice: {Price}");
    }
}

public class Phone : Product
{
    public string OperatingSystem { get; set; }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Operating System: {OperatingSystem}");
    }
}

public class Car : Product
{
    public string Model { get; set; }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Model: {Model}");
    }
}

public class Shop
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }

    public void PrintProductList()
    {
        foreach (var product in products)
        {
            product.PrintInfo();
        }
    }
}

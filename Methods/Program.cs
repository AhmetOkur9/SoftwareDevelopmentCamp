using Methods;

Product product1 = new Product();
product1.Name = "Apple";
product1.Charge = 15;
product1.About = "Amasya Apple";

Product product2 = new Product();
product2.Name = "Watermelon";
product2.Charge = 80;
product2.About = "Diyarbakir Watermelon";

Product[] products = new Product[] {product1, product2 };

foreach (Product product in products)
{

}

Console.WriteLine("------------Methods----------");

SepetManager sepetManger = new SepetManager();
sepetManger.Add(product1);
sepetManger.Add(product2);

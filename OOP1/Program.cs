using OOP1;

Product product1= new Product();
product1.Id= 1;
product1.CategoryId= 2;
product1.ProductName= "Table";
product1.UnitPrice = 500;
product1.UnitsInStock= 3;

Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, ProductName="Pen", UnitPrice=35 };

ProductManager productManager = new ProductManager();
productManager.Add(product1);

productManager.addition2(3, 6);

int collectionResult = productManager.addition(3, 6 * 2);
Console.WriteLine(productManager.addition(3,6 * 2));
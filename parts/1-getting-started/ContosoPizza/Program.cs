using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

// Product veggieSpecial = new Product()
// {
//     Name = "Veggie Special Pizza",
//     Price = 9.99M
// };
// context.Products.Add(veggieSpecial);

// Product deluxeMeat = new Product()
// {
//     Name = "Deluxe Meat Pizza",
//     Price = 12.99M
// };
// context.Add(deluxeMeat);

// context.SaveChanges();

// var products = context.Products
//     .Where(p => p.Price > 10)
//     .OrderBy(p => p.Name);

// foreach (var product in products)
// {
//     Console.WriteLine($"Id: {product.Id}");
//     Console.WriteLine($"Name: {product.Name}");
//     Console.WriteLine($"Price: {product.Price}");
//     Console.WriteLine(new string('-', 20));
//     Console.WriteLine();
// }

// var veggieSpecial = context.Products
//                        .Where(p => p.Name == "Veggie Special Pizza")
//                        .FirstOrDefault();

// if (veggieSpecial is Product)
// {
//     veggieSpecial.Price = 10.99M;
// }

// context.Remove(veggieSpecial);

// context.SaveChanges();

var products = context.Products
    .Where(p => p.Price > 10)
    .OrderBy(p => p.Name);

foreach (var product in products)
{
    Console.WriteLine($"Id: {product.Id}");
    Console.WriteLine($"Name: {product.Name}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine(new string('-', 20));
    Console.WriteLine();
}

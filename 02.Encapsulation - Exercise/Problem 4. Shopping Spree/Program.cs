using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Shopping_Spree
{
    public class Program
    {
        public static void Main()
        {

            var allPeopleInput = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var people = new List<Person>();

            var products = new List<Product>();
            var allProductsInput = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (var person in allPeopleInput)
                {
                    var tokens = person.Split('=');
                    var name = tokens[0];
                    var money = double.Parse(tokens[1]);
                    var currentPeson = new Person(name, money);
                    people.Add(currentPeson);
                }
                foreach (var product in allProductsInput)
                {
                    var tokens = product.Split('=');
                    var productName = tokens[0];
                    var costs = double.Parse(tokens[1]);
                    var currentProduct = new Product(productName, costs);
                    products.Add(currentProduct);
                }

                while (true)
                {
                    var inputLine = Console.ReadLine();
                    if (inputLine == "END")
                    {
                        break;
                    }

                    var tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var personName = tokens[0];
                    var productName = tokens[1];

                    var buyer = people.FirstOrDefault(b => b.Name == personName);
                    var productToBuy = products.FirstOrDefault(bp => bp.Name == productName);

                    try
                    {
                        buyer.BuyProduct(productToBuy);
                        Console.WriteLine($"{buyer.Name} bought {productToBuy.Name}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                }

                foreach (var person in people)
                {
                    var boughtProducts = person.GetProducts();
                    if (boughtProducts.Any())
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", boughtProducts.Select(p => p.Name).ToList())}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

    }
}


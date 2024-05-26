
namespace Product
{
    class Program
    {
        static void Main()
        {
            Inventory inventory = new Inventory();
            inventory.AddProduct("Pen", 50);
            inventory.AddProduct("Notebook", 100);
            inventory.AddProduct("Eraser", 30);

            Console.WriteLine("Products and Quantities in Inventory:");
            foreach (var product in inventory.Products)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
            inventory.UpdateQuantity("Pen", 20);
            Console.WriteLine("\nAfter updating quantity of Pen:");
            foreach (var product in inventory.Products)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
            inventory.RemoveProduct("Notebook");
            Console.WriteLine("\nAfter removing Notebook:");
            foreach (var product in inventory.Products)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
            int quantityOfPen = inventory.GetQuantityByProduct("Pen");
            Console.WriteLine($"\nQuantity of Pen: {quantityOfPen}");
            Console.WriteLine("\nProducts and Quantities in Inventory:");
            foreach (var product in inventory.Products)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
        }
    }
}
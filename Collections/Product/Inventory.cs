namespace Product
{
    internal class Inventory
    {
        public Dictionary<string, int> Products { get; set; }

        public Inventory()
        {
            Products = new Dictionary<string, int>();
        }

        public void AddProduct(string productName, int quantity)
        {
            if (Products.ContainsKey(productName))
            {
                Products[productName] += quantity;
            }
            else
            {
                Products.Add(productName, quantity);
            }
        }

        public void RemoveProduct(string productName)
        {
            if (Products.ContainsKey(productName))
            {
                Products.Remove(productName);
            }
            else
            {
                Console.WriteLine("Product not found in inventory.");
            }
        }

        public void UpdateQuantity(string productName, int newQuantity)
        {
            if (Products.ContainsKey(productName))
            {
                Products[productName] = newQuantity;
            }
            else
            {
                Console.WriteLine("Product not found in inventory.");
            }
        }

        public int GetQuantityByProduct(string productName)
        {
            if (Products.ContainsKey(productName))
            {
                return Products[productName];
            }
            else
            {
                Console.WriteLine("Product not found in inventory.");
                return -1;
            }
        }

        public Dictionary<string, int> GetProducts()
        {
            return Products;
        }
    }
}
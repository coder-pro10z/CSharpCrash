using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        public string? _cartId { get; set; }
        public Dictionary<string, double>? _items { get; set; } //Defined a nullable Dictionary for an empty Cart
        public Cart() { } //A Default Constructor

        //A parameterized constructor for Cart - 2 params cartId, items
        public Cart(string cartId, Dictionary<string, double> items)
        {
            _cartId = cartId;
            
                _items = items;

        }
        //Only parmaterized with Cart Id and Empty Dictionary of items - 1 param
        public Cart(string cartId)
        {
            _cartId = cartId;

            _items =new Dictionary<string, double>();

        }

        //TO Add an item 
        public void AddItem(string key, double value) {
            _items?.Add(key, value);
        }

        //To Remove an Item
        public void RemoveItem(string key)
        {
            _items?.Remove(key);
        }
      //To Get Total of the Cart
        public double GetTotal()
        {
            double total = 0;
            foreach (var item in _items) {
                total += item.Value;
            }
            return total;
        }

        //To print the Output
        public override string ToString()
        {
            Console.WriteLine($"\nCart ID: {_cartId}");
            foreach (KeyValuePair<string, double> item in _items)
            {
                string itemName = item.Key;
                Console.WriteLine($"Item Name : {itemName},\tCost : {item.Value.ToString("F2")}");
            }
            return $"Total: {GetTotal().ToString("F2")}";
        }
    }
}

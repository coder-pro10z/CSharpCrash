using ShoppingCart;

/// Create a class that Represent a shoppping cart in an ecommerce application
///
/// The Cart class should have the following instance fields:
///_cartId (string)
///_items (Dictionary of <string,double> such as "lollypop",2.5)
///
///The Cart class should have the following methods:
///Optionally Add Constructors or TOString Methods:
///AddItems - Adds an item to the cart
///RemoveItem - Removes an item from the cart
///Get Total - Returns the total cost of the items in the cart
///
Cart shoppingCart = new Cart();

//First creating a Dictionary to add to the Cart Directly
Dictionary<string,double> cartData = new Dictionary<string,double>();
cartData["lollypop"] = 2.5;
cartData["candy"] = 5.0;

//initializing cart1 with manual data using a String and Dictionary object 
Cart shoppingCart1 = new Cart("1",cartData);

//Add to Cart1 
shoppingCart1.AddItem("Soap",3);

//Remove From Cart1
shoppingCart1.RemoveItem("candy");
Console.WriteLine(shoppingCart1);

Cart shoppingCart2 = new Cart("2");

//Add to cart2
shoppingCart2.AddItem("Basket", 4);
shoppingCart2.AddItem("Cap", 2);
shoppingCart2.AddItem("Ball", 1.5);
Console.WriteLine(shoppingCart2);






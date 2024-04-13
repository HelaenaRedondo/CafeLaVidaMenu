using CafeMenuBL;

internal class Program
{
    public static void Main(string[] args)
    {
        CafeMenu myCafeMenu = new CafeMenu
        {
            name = "My recommended drinks.."
        };

        CafeMenu bestdrinks = new CafeMenu
        {
            name = "La Vida Coffee Shop",
            opening = "9 am",
            closing = "10 pm",
            owner = "Helaena Redondo",
            type = "Arabica",
            menu = "Coffee",
            drinks = "IcedHotTeasFrappeSmoothies",
            iced = "Ice Latte,Iced Mocha, Ice chocolate",
            frappe = "Double choco,Mocha,Caramel,Strawberry",
            hot = "Capuccino,Mochaccino,Cafe Latte",
            tea = "Jasmine,peppermint,Black Tea",
            smoothies = "Dalandan, Strawberyy",
        };
        {
            Console.Write("Type of Drinks:  ");
            string CafeMenu = Console.ReadLine();
            Console.Write("Flavor: ");
            string Drinks = Console.ReadLine();

            CafeMenu menu = new CafeMenu();
            bool result = myCafeMenu.Equals(bestdrinks.name);

            if (result)
            {
                Console.WriteLine("Not Availavble :(");
                menu.DisplayCafeMenus(bestdrinks);
            }
            else
            {
                {
                    Console.WriteLine("Available :)");
                    myCafeMenu.DisplayCafeMenus(bestdrinks);
                }
            }
        }
    }
}
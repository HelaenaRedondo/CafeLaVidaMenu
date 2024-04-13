
namespace CafeMenuBL
{
    public class CafeMenu
    {
        List<CafeMenu> cafeList = new List<CafeMenu>();
        public String name = "";
        public string opening;
        public string closing;
        public string owner;
        public string type;
        public string menu;
        public string drinks;
        public string iced;
        public string frappe;
        public string hot;
        public string tea;
        public string smoothies;
        private CafeMenu cafes;

        public void AddCafe(CafeMenu cafe)
        {
            cafeList.Add(cafe);
        }

        public void DeleteCafe(CafeMenu CafeMenu)
        {
            cafeList.Remove(cafes);
        }

        public void DisplayCafeMenus(CafeMenu cafe)
        {
           
            Console.WriteLine("----------------------");
            Console.WriteLine("Name: "
                + cafe.name);
            Console.WriteLine("Opening: "
                + cafe.opening);
            Console.WriteLine("Closing: " + cafe.closing);
            Console.WriteLine("Onwer: " + cafe.owner);
            Console.WriteLine("Type of Coffe: " + cafe.type);
            Console.WriteLine("----------------------");
                   Console.WriteLine($"- - - Cafe Menus - - -");
            Console.WriteLine($"Welcome to La Vida Cafe!");
            Console.WriteLine("Menu: " + cafe.menu);
            Console.WriteLine("Drinks: " + cafe.drinks);
            Console.WriteLine("Iced: " + cafe.iced);
            Console.WriteLine("Frappe: " + cafe.frappe);
            Console.WriteLine("Hot: " + cafe.hot);
            Console.WriteLine("Tea: " + cafe.tea);
            Console.WriteLine("Smoothies: " + cafe.smoothies);
            Console.WriteLine("----------------------");
        }

    }
} 


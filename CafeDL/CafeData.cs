using System.ComponentModel.Design;
using CafeModel;

namespace CafeDL
{
    public class CafeData
    {
        public string StayHydrated;
        List<CafeData> cafes = new List<CafeData>();

        public string Menu { get; }

        private string drinks;
        private string frappe;
        private string hot;
        private string tea;
        private string smoothies;
        private string bestrdinks;
        private string bestdrinks1;
        private string bestdrinks2;

        public CafeData()
        {
            CafeData bestDrinks = new CafeData();
            {
                Menu = "Coffee";
                drinks = "IcedHotTeasFrappeSmoothies";
            };
            CafeData bestDrinks1 = new CafeData();
            {
                hot = "Capuccino,Mochaccino,Cafe Latte";
            };
            CafeData bestDrinks2 = new CafeData();
            {
                frappe = "Double choco,Mocha,Caramel,Strawberry";
            };
            CafeData bestdrinks3 = new CafeData();
            {
                tea = "Jasmine,peppermint,Black Tea";
            };
            CafeData bestdrinks4 = new CafeData();
            {
                smoothies = "Dalandan, Strawberyy";
            };

            cafes.Add(bestDrinks);
            cafes.Add(bestDrinks1);
            cafes.Add(bestDrinks2);
            cafes.Add(bestdrinks3);
            cafes.Add(bestdrinks4);
        }
        public void AddCafes(CafeData cafedata)
        {
            cafes.Add(cafedata);
        }
        public List<CafeData> GetCafeMenuList()
        {
            return cafes;
        }
    }
}

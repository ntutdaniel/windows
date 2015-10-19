using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosOrderSystem
{
    public class MealData
    {
        private String[] _name = { "BigMac", "4 Oz Beef Burger", "Double 4 Oz Beef Burger", "Bacon Beef Burger", "6 pcs Chicken Nugget", "9 pcs Chicken Nugget", "Filet-O-Fish", "Pancake",
        "Pancake Pork", "Big Breakfast", "McFLurry", "Pineapple Pie", "Apple Pie", "Potato Chip(S)", "Potato Chip(L)" };
        private int[] _price = { 39, 85, 115, 99, 69, 95, 75, 52, 57, 94, 48, 27, 28, 25, 49 };
        private String[] _description = { "The Big Mac consists of two 1.6 oz (45.4 g) 100 per cent beef patties, American cheese, special sauce (a variant of Thousand Island dressing), iceberg lettuce, pickles, and onions, served in a three-part sesame seed bun.",
        "Made by our pro butchers, these 100% British steak burgers are made using only the finest Free Range British beef.",
        "The Daily Double burger has two 100% beef patties, American cheese topped with lettuce, onions, mayo and a juicy slice of tomato.",
        "Bacon McDouble burger has two 100% beef patties topped with American cheese, thick cut smoked bacon, onions, pickles, ketchup and mustard on a toasted bun.",
        "This Chicken McNuggets ShareBox has 6 golden crispy chicken nuggets and a choice of four delicious dips.",
        "This Chicken McNuggets ShareBox has 9 golden crispy chicken nuggets and a choice of four delicious dips.",
        "Filet-O-Fish burger from McDonald's is made from white fish caught from a sustainable fishery, melted cheese and tartar sauce in a steamed bun.",
        "A pancake is a flat cake, often thin, and round, prepared from a starch-based batter that may also contain eggs, milk and butter and cooked on a hot surface such as a griddle or frying pan, often with oil or butter.",
        "A pancake is a flat cake, often thin, and round, prepared from a starch-based batter that may also contain eggs, milk and butter and pork and cooked on a hot surface such as a griddle or frying pan, often with oil or butter.",
        "Satisfaction guaranteed with a fresh-baked buttermilk biscuit, savory hot sausage, fluffy scrambled eggs, crispy hash browns and golden brown hotcakes. You can also enjoy it with 100%, freshly grilled egg whites instead.",
        "Reduced fat soft serve vanilla ice cream, with M&M's® candies swirled in. It's a moo-tiful partnership.",
        "It's the tradition you love to uphold, with delicious apples lightly spiced with cinnamon, baked in flaky pastry.",
        "It's the tradition you love to uphold, with delicious apples lightly spiced with cinnamon, baked in flaky pastry.",
        "A potato chip (American English) or crisp (British English) is a thin slice of potato that has been deep fried, baked, kettle cooked, or popped until crunchy.",
        "A potato chip (American English) or crisp (British English) is a thin slice of potato that has been deep fried, baked, kettle cooked, or popped until crunchy." };

        private List<Meal> _mealList = new List<Meal>();

        public MealData()
        {
            for (int mealIndex=0; mealIndex < _name.Count(); mealIndex++)
            {
                SetMeal(_name[mealIndex], _price[mealIndex], _description[mealIndex]);
            }
        }

        public void SetMeal(string name, int price, string description)
        {
            Meal meal = new Meal();
            meal.SetName(name);
            meal.SetPrice(price);
            meal.SetDescription(description);
            _mealList.Add(meal);
        }

        public Meal GetMeal(int mealIndex)
        {
            return _mealList[mealIndex];
        }

        public int GetDataCount()
        {
            return _mealList.Count;
        }
    }
}

public class Meal
{
    private string _name;
    private int _price;
    private string _description;
    private string _photoPath;

    public Meal()
    {

    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetPrice(int price)
    {
        _price = price;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPhotoPath(string photoPath)
    {
        _photoPath = photoPath;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPrice()
    {
        return _price;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPhotoPath()
    {
        return _photoPath;
    }
}

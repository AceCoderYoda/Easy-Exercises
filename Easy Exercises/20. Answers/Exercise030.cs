#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise030.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise030
    {
        private static void Main(string[] args)
        {
            Console.Write("\nLINQ : Arrange distinct elements in the list in ascending order : ");
            Console.Write("\n----------------------------------------------------------------\n");

            var itemlist = (from c in Item_Mast.GetItemMast()
                    select c.ItemDes)
                .Distinct()
                .OrderBy(x => x);

            foreach (var item in itemlist)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }

    internal class Item_Mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }

        public static List<Item_Mast> GetItemMast()
        {
            var itemlist = new List<Item_Mast>();
            itemlist.Add(new Item_Mast {ItemId = 1, ItemDes = "Biscuit  "});
            itemlist.Add(new Item_Mast {ItemId = 2, ItemDes = "Honey    "});
            itemlist.Add(new Item_Mast {ItemId = 3, ItemDes = "Butter   "});
            itemlist.Add(new Item_Mast {ItemId = 4, ItemDes = "Brade    "});
            itemlist.Add(new Item_Mast {ItemId = 5, ItemDes = "Honey    "});
            itemlist.Add(new Item_Mast {ItemId = 6, ItemDes = "Biscuit  "});
            return itemlist;
        }
    }
}
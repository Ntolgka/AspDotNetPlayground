using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDotNetPlayground.Models
{
    public static class Data
    {
        public static List<Item> _list;

        static Data()
        {
            _list = new List<Item>()
            {
                new Item() {ItemId=1, ItemName="Iphone 7", Description="New", Price=1000, IsOnSale=true, Picture="1.jpg"},
                new Item() {ItemId=2, ItemName="Iphone 8", Description="Used", Price=800, IsOnSale=false, Picture="2.jpg"},
                new Item() {ItemId=3, ItemName="Iphone X", Description="New", Price=1200, IsOnSale=false, Picture="3.jpg"},
                new Item() {ItemId=4, ItemName="Iphone XS", Description="Bad condition", Price=500, IsOnSale=true, Picture="4.jpg"},
                new Item() {ItemId=5, ItemName="Iphone 11", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis at nulla eu neque interdum euismod. In tincidunt blandit tellus, posuere commodo magna fermentum ac. In rhoncus, odio nec aliquet lobortis, odio mi dignissim nunc, ut porta turpis elit eget arcu. Morbi congue", Price=1400, IsOnSale=true, Picture="5.jpg"},
                new Item() {ItemId=6, ItemName="Iphone 12", Description="New", Price=1500, IsOnSale=false, Picture="6.jpg"}
            };
        }
         
        public static List<Item> List
        {
            get { return _list; }
        }

        public static void addItem(Item entity)
        {
            _list.Add(entity);
        }

        public static Item ItemDetail(int itemId)
        {
            Item entity = null;

            foreach (var item in _list)
            {
                if (item.ItemId == itemId)
                {
                    entity = item;
                }
            }
            return entity;
        }

    }
}
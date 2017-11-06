using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace U241017A.Data
{
    public class Repository
    {

        public static Repository _repo = new Repository();
        public static Repository GetRepo { get { return _repo; } }


        private List<Product> prod = new List<Product>();

        public Repository()
        {
            prod.Add(new Product() { Name = "Florida", Event = "Flyg", Date = "25/7" , Location = "Arlanda", Id = 10 });
            prod.Add(new Product() { Name = "Berlin", Event = "Flyg", Date = "26/7", Location = "Arlanda", Id = 20 });
            prod.Add(new Product() { Name = "Moskva", Event = "Flyg", Date = "27/7", Location = "Arlanda", Id = 30 });
            prod.Add(new Product() { Name = "Stockholm", Event = "Flyg", Date = "28/7", Location = "Arlanda", Id = 40 });
            prod.Add(new Product() { Name = "Barcelona", Event = "Flyg", Date = "29/7", Location = "Arlanda", Id = 50 });
        }

        public List<Product> Products
        {
            get
            {
                return prod;
            }
        }

        //Update
        public void Add(Product p)
        {
            int id = prod.Max(x => x.Id);
            p.Id = id + 10;
            prod.Add(p);
        }

        //Delete
        public void Remove(int id)
        {
            Product p = prod.Find(x => x.Id == id);
            prod.Remove(p);
        }

    }
}

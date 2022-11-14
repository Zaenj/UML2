using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigmommasPizzaa
{
    public class PizzaMenu
    {
        private Dictionary<int, Pizza> _id;

        public PizzaMenu()
        {
            _id = new Dictionary<int, Pizza>();
        }
        public int Count
        {
            get { return _id.Count; }
        }
        
        public void CreatePizza(Pizza aPizza)
        {
            if (_id.ContainsKey(aPizza.id))
            {
                Console.WriteLine($"The pizza with the id {aPizza.id}, already exists");
            }
            else
            {
                _id.Add(aPizza.id, aPizza);
                Console.WriteLine($"Pizza added, {aPizza}");
            }
        } 
        public Pizza LookupPizza(int id)
        {
            if (_id.ContainsKey(id))
            {
                Console.WriteLine($"Pizza Found:{_id[id]}");
            }
            else
            {
                Console.WriteLine($"Pizza with id {id} not found");
            }
            return null;
        }
        public void DeletePizza(int id)
        {
            if (_id.ContainsKey(id))
            {
                Console.WriteLine($"Pizza deleted; {_id[id]}");
            }
            else
            {
                Console.WriteLine($"Could not find any pizzas with the id {id} too remove");
            }

        }

        public void UpdatePizza(int id, string newname, int newpris)
        {
            foreach (var item in _id)
            {
                if (item.Key == id)
                {
                    _id[id].pizzaname = newname;
                    _id[id].pris = newpris;
                    _id[id].id = id;
                    Console.WriteLine($"Pizzas updated: {_id[id]}");
                }
                
            }
        }
        public void PrintMenu()
        {
            foreach (var Pizza in _id)
            {
                Console.WriteLine(Pizza);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BigmommasPizzaa
{
    public class Store
    {
        public void Start()
        {
            PizzaMenu pizzaMenu = new PizzaMenu();
            
            //creating base pizzas
            Pizza pizza1 = new Pizza("Salat", 50, 1);
            Pizza pizza2 = new Pizza("Kødstrimler", 49, 2);
            Pizza pizza3 = new Pizza("Magarita", 40, 3);

            // Create Pizza
            Console.WriteLine("----------Created Pizzas----------");
            pizzaMenu.CreatePizza(pizza1);
            pizzaMenu.CreatePizza(pizza2);
            pizzaMenu.CreatePizza(pizza3);

            Console.WriteLine("");

            //Creating Pizza that already exists
            Console.WriteLine("------------Pizza Already exists-------------");
            pizzaMenu.CreatePizza(pizza1);

            Console.WriteLine("");


            Console.WriteLine("---------------New Pizza Added------------");
         
            // Creating new pizza
            pizzaMenu.CreatePizza(new Pizza("Pepperoni", 40, 4));
            pizzaMenu.CreatePizza(new Pizza("Hassan special", 51, 5));
            pizzaMenu.CreatePizza(new Pizza("Henrik special",399, 6));

            Console.WriteLine("");

            Console.WriteLine("--------------Look up Pizza---------------");

            // Lookup Pizza
            pizzaMenu.LookupPizza(1);
            pizzaMenu.LookupPizza(3);
            pizzaMenu.LookupPizza(4);
            pizzaMenu.LookupPizza(5);
            pizzaMenu.LookupPizza(6);
            pizzaMenu.LookupPizza(7);

            Console.WriteLine("");

            Console.WriteLine("------------Deleted Pizzas--------------");
           
            // Delete a Pizza using id
            pizzaMenu.DeletePizza(2);
            pizzaMenu.DeletePizza(7);

            Console.WriteLine("");


            Console.WriteLine("--------------Pizzas updated-------------");
            // Update Pizzas by id, then change name and price
            pizzaMenu.UpdatePizza(1, "Xoyes", 141);
            pizzaMenu.UpdatePizza(3, "newpizza2", 10);

            
            Console.WriteLine("");

            Console.WriteLine("----------------Print Menu-------------");
           
            //print pizza menu
            pizzaMenu.PrintMenu();


            Console.WriteLine("");



            CustomerFile customerfile = new CustomerFile();

            //Customers
            Kunde kunde1 = new Kunde("Hassan", "2635 ishøj", "Hassan@hotmail.com", "4214157", 1);
            Kunde kunde2 = new Kunde("Deniz", "2414 monvej", "DenzWBenz@hotmail.com", "2429141", 2);
            Kunde kunde3 = new Kunde("alpCinderella", "xoyesvej 14", "xoyes@hotmail.com", "4111414", 3);


            Console.WriteLine("-----------Customers------------");
          
            //Add customers
            customerfile.AddCustomer(kunde1);
            customerfile.AddCustomer(kunde2);
            customerfile.AddCustomer(kunde3);

            Console.WriteLine(""); 

            Console.WriteLine("----------------Lookup Kunde---------------");
          
            //Lookup customers using their names
            customerfile.LookupCustomer("Hassan");
            customerfile.LookupCustomer("Deniz");
            customerfile.LookupCustomer("Sami");
            customerfile.LookupCustomer("4");

            Console.WriteLine("");


            Console.WriteLine("---------------------Added new customer-----------------");  
          
            //Add new customers to list
            customerfile.AddCustomer(new Kunde("Sami", "Køge", "123@hotmail.com", "12421451", 4));

            Console.WriteLine("");

            Console.WriteLine("--------------------Customers deleted--------------");

            customerfile.DeleteCustomer("Hassan");
            customerfile.DeleteCustomer("afafa");
            //customerfile.DeleteCustomer(10);

            Console.WriteLine("");


            Console.WriteLine("---------------Customers updated----------------");
            //Update Customer using id and then change name, adress, email and number
            customerfile.UpdateCustomer(2, "Zaen", "Pakistan", "hej@hotmail.com", "412421441");

            Console.WriteLine("");

            Console.WriteLine("-------------Kunde PrintMenu----------------");

            //Print out all customers
            customerfile.PrintMenu();

            //Ordre ordre1 = new Ordre(1, pizza1, kunde1);
            //Ordre ordre2 = new Ordre(2, pizza2, kunde2);
            //Ordre ordre3 = new Ordre(3, pizza3, kunde3);

            //Console.WriteLine(pizza1);
            //Console.WriteLine(kunde1);
            //Console.WriteLine(ordre1);

            //Console.WriteLine();

            //Console.WriteLine(pizza2);
            //Console.WriteLine(kunde2);
            //Console.WriteLine(ordre2);

            //Console.WriteLine();

            //Console.WriteLine(pizza3);
            //Console.WriteLine(kunde3);
            //Console.WriteLine(ordre3);
        }

    }
}



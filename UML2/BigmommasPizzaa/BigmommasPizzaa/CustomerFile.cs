using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BigmommasPizzaa
{
    public class CustomerFile
    {
        private List<Kunde> _nameCustomer;

        
       public CustomerFile()
        {
            _nameCustomer = new List<Kunde>();
        }
        
        public int Count 
        {
            get { return _nameCustomer.Count; }
        }


        //Add single customer
        public void AddCustomer(Kunde Kunde)
        {
            _nameCustomer.Add(Kunde);
            Console.WriteLine($"Customer added: {Kunde}");
        }

        public Kunde LookupCustomer(string name)
        {
            foreach (var kunde in _nameCustomer)
            {
                if (kunde.nameCustomer == name)
                {
                    Console.WriteLine("Læser Kunde op:");
                    Console.WriteLine(kunde);
                }
              

            }
            return null;
        }

   
        public Kunde DeleteCustomer(string nameCustomer)
        {
            foreach (var kunde in _nameCustomer)
            {
               if (kunde.nameCustomer == nameCustomer)
                {
                    Console.WriteLine($"Customer {nameCustomer} deleted");
                    return kunde;
                }
              
            }
            return null;
        }



        public void UpdateCustomer(int id, string newname, string newadresse, string newemail, string newtelefon)
        {
            foreach (var item in _nameCustomer)
            {
                if ( item.ISBN == id)
                {
                    _nameCustomer[id].nameCustomer = newname;
                    _nameCustomer[id].adresseCustomer = newadresse;
                    _nameCustomer[id].emailCustomer = newemail;
                    _nameCustomer[id].telefonCustomer = newtelefon;
                    _nameCustomer[id].ISBN = id;
                    Console.WriteLine($"Customer updated: {_nameCustomer[id]}");
                }

            }
        }
        public void PrintMenu()
        {
            foreach ( Kunde kunde in _nameCustomer)
            {
                Console.WriteLine(kunde);
            }
        }
        


    }
}
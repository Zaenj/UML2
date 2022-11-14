using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigmommasPizzaa
{
    public class Ordre
    #region Instance Field
    {
        private int _ordreNr;
        Pizza _pizzaItem;
        Kunde _kunde;
        
        #endregion

        #region Constructor

        public Ordre(int ordreNr, Pizza pizzaItem, Kunde kunde)

        {
            _ordreNr = ordreNr;
            _pizzaItem = pizzaItem;
            _kunde = kunde;
        }
        #endregion

     public int ordreNr
        {
            get { return _ordreNr; }
     
        }

        private double CalculateTotalPrice(double price)
        {
            return (price) * 1.25 + 40;
        }
        public override string ToString()
        {
            return "Din ordre" + _kunde + " " + _pizzaItem + " " + "total pris er:" + CalculateTotalPrice(_ordreNr);


        }

    }
    
    

}
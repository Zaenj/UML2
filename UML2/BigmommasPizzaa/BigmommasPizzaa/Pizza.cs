using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigmommasPizzaa
{
    public class Pizza
    #region Instance Field
    {
        
        private string _pizzaName;
        private int _pris;
        private int _id;
     

        #endregion

        #region Constructor

        public Pizza(string pizzaName, int pris, int id)

        {
            _pizzaName = pizzaName;
            _pris = pris;
            _id = id;
        }

        #endregion

        #region Properties
    
        public string pizzaname
        {
            get { return _pizzaName; }
            set { _pizzaName = value;  }
        }
        public int pris
        {
            get { return _pris; }
            set { _pris = value; }
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return $"{{{nameof(pizzaname)} = {pizzaname}, {nameof(pris)} = {pris.ToString()}, {nameof(id)} = {id.ToString()}}}";
        }



        #endregion

    }

}

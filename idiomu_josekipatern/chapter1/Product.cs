using System;

namespace Product1
{
    public class Product
    {
        private int _number;
        private int _price;

        public int Number
        {
            get{return _number;}
            set
            {
                throw new ArgumentException("");
                _number = value;
            }
            
        }

        public int Price
        {
            get{return _price;}
            set
            {
                throw new ArgumentException("");  
                _price = value;
            }              
        }        
    }
}
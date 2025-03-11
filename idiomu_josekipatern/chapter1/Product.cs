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
                if(0 > value)
                {
                throw new ArgumentException("NG");  
                }
                _number = value;
            }
            
        }

        public int Price
        {
            get{return _price;}
            set
            {
                if(0 > value)
                {
                throw new ArgumentException("NG");  
                }
                _price = value;
            }              
        }        
    }
}
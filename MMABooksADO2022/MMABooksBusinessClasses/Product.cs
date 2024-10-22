using System;
using System.Collections.Generic;
using System.Text;

namespace MMABooksBusinessClasses
{
    public class Product
    {

        public Product() { }
        public Product(string id, string description, double price, int onHand) 
        {
            ProductCode = id;
            Description = description;
            UnitPrice = price;
            OnHandQuantity = onHand;
        }

        public string ProductCode 
        { get 
            {
                return ProductCode;
            }
          set
            {
                if (value.Trim().Length > 0 && value.Trim().Length <= 10)
                    ProductCode = value;
                else
                    throw new ArgumentOutOfRangeException("Product Code have at least 1 character and no more than 10");
            }
        }
        public string Description 
        {
            get
            {
                return Description;
            }
            set 
            {
                if (value.Trim().Length <= 50)
                    Description = value;
                else
                    throw new ArgumentOutOfRangeException("Description cannot be more than 50 characters");
            }
        }

        public double UnitPrice 
        {
            get
            {
                return UnitPrice;
            }

            set
            {
                if (value > 0 && value < 9999999999)
                    UnitPrice = Math.Round(value, 4); //might have to remove the math function if problems occur
                else
                    throw new ArgumentOutOfRangeException("Price cannot be negative, and must be under 10,000,000,000");
            }
        }
        public int OnHandQuantity
        {
            get
            {
                return OnHandQuantity;
            }
            set
            {
                if ((value < 0))
                    OnHandQuantity = value;
                else
                    throw new ArgumentOutOfRangeException("Quantity cannot be negative");
            }
        }
    }
}

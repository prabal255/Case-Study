using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Cognizant.Truyum.Dao
{
    class CartEmptyException:Exception
    {
        public CartEmptyException()
        {
            Console.WriteLine("Empty cart");
        }
    }
}

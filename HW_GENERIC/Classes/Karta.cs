using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GENERIC.Classes
{


    public class Karta
    {

        public string Suit_card { get; set; } 

        public string Type_card { get; set; } 
              
        public void PrintKarta()
        {
            Console.WriteLine(Type_card + " " + Suit_card);
        }
    }
}

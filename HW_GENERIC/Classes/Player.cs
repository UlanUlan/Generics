using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GENERIC.Classes
{
    public class Player
    {
        public string Name { get; set; }
        public List<Karta> kartas = new List<Karta>(); 

        public void PrintKartas()
        {
            Console.WriteLine("\t" + Name);
            foreach (Karta item in kartas) 
            {
                Console.WriteLine("\t" + item.Type_card + " | " + item.Suit_card);
            }
        }
    }
}

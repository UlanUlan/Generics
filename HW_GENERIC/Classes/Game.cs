using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_GENERIC.Classes
{
    public class Game
    {
        public Game() { }
        Generator generator = new Generator();

        public List<Player> gamers = Generator.CreateGamers();

        int i = 1;

        List<Karta> koloda = Generator.GetColoda();

        public void Mix()
        {
          Console.WriteLine("Тасуем колоду!");
       
            koloda = Generator.MixColoda();
           
        }
    
        public void Razdacha()
        {
            int index = gamers.Count; 
            int a = koloda.Count / index; 
            int b = a;

            while (index > 0)
            {
                while (a > 0)
                {
                    gamers[index - 1].kartas.Add(koloda[a - 1]);
                    a--;
                }

                index--;
            }

            while (index > 0)
            {
                Console.WriteLine(gamers[index - 1].Name);
                index--;
            }

            Console.WriteLine("Раздали карты!");
        }





    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GENERIC.Classes
{
 
    public enum Suit {Буби = 1, Черви, Крести, Пики };
    public enum Type { шесть = 6, семь, восемь, девять, десять, Валет, Дама, Король, Туз };

    public class Generator
    {

        static Random rand = new Random();
        static List<Player> gamers = new List<Player>();
        static List<Karta> coloda = new List<Karta>();
        static int i = 0;
        static int countPlayers = 0;

        static public List<Player> CreateGamers()
        {
            for (int i = 0; i < rand.Next(2, 5); i++)
            {
                Player player = new Player();
                player.Name = "Player-" + (i + 1);
                countPlayers++;
                gamers.Add(player);
            }

            return gamers;
        }


        static public Karta CreateKarta()
        {
                Karta karta = new Karta();
                karta.Type_card = ((Type)(rand.Next(6, 15))).ToString();
                karta.Suit_card = ((Suit)(rand.Next(1, 5))).ToString();
           return karta;
        }

       static public List<Karta> GetColoda()
        {
          do
            {
                Karta karta = CreateKarta();

                if (coloda.Count == 0)
                {
                    coloda.Add(karta);
                    i++;
                }
                else
                {                   
                      if (IsExist(coloda, karta))
                            GetColoda(); 
                        else
                        {
                            coloda.Add(karta);
                          i++;
                         }
                }
            } while (i < 36);
         return coloda;

        }
        public void PrintColoda()
        {
          int i = 1;
          
            foreach (Karta item in coloda)
            {
                Console.WriteLine(i + " " + item.Type_card + " " + item.Suit_card );
                i++;
            }
        }

        static public bool IsExist(List<Karta> karts, Karta karta)
        {
            foreach (Karta item in karts)
                if (item.Suit_card == karta.Suit_card && item.Type_card == karta.Type_card)
                    return true;
            return false;
        }

   
        static public List<Karta> MixColoda()
        {
         List<Karta> coloda1 = GetColoda();
               return coloda1;
        }


    }
}

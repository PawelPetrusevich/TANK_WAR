using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class TANK
    {
        int armor;
        int speed;
        int weapon;
        /// <summary>
        /// Конструктор танка
        /// </summary>
        /// <param name="armor"></param>
        /// <param name="speed"></param>
        /// <param name="weapon"></param>
        public TANK(int armor,int speed,int weapon)
        {
            this.armor = armor;
            this.speed = speed;
            this.weapon = weapon;
        }
        /// <summary>
        /// перегрузка оператора ^
        /// </summary>
        /// <param name="t34"></param>
        /// <param name="pantera"></param>
        /// <returns></returns>
        public static bool operator ^(TANK t34,TANK pantera)
        {
            
                
                int t34Count = 0;
                int panteraCount = 0;
                #region Сравнение параметров            
                if (t34.armor > pantera.armor)
                {
                    t34Count++;
                }
                else
                {
                    panteraCount++;
                }

                if (t34.speed > pantera.speed)
                {
                    t34Count++;
                }
                else
                {
                    panteraCount++;
                }

                if (t34.weapon > pantera.weapon)
                {
                    t34Count++;
                }
                else
                {
                    panteraCount++;
                }
                if ((t34.weapon == pantera.weapon) && (t34.speed == pantera.speed) && (t34.armor == pantera.armor))
                {
                    Exception WarException = new Exception();
                    throw WarException;
                   
                }           
            #endregion

                if (t34Count > panteraCount)
                {
                    return true;

                }
                else
                {
                    return false;
                }
        }
        /// <summary>
        /// Метод боя. 
        /// </summary>
        /// <param name="T34">Массив танков Т34 </param>
        /// <param name="Pantera">Массив танков пантер </param>
        /// <returns></returns>
        public static bool WAR(TANK[] T34,TANK[] Pantera)
        {
            int t34Count = 0;
            int panteraCount = 0;

            for (int i = 0; i < 5; i++)
            {


                try
                {
                    
                if (T34[i] ^ Pantera[i])
                {          
                    t34Count++;
                    Console.WriteLine("Бой выграли T34");
                                        
                }
                else
                {
                    panteraCount++;
                    Console.WriteLine("Бой выграли Pantera");
                  
                }
                }
                catch (Exception)
                {
                    Console.WriteLine("Равный бой");
                }
                

            }
            if (t34Count == panteraCount)
            {
                Exception WarExc = new Exception();
                throw WarExc;
            }
            if (t34Count>panteraCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

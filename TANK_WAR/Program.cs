using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank;
using System.Data;
namespace TANK_WAR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание танка Т34
            //Рабочий рандом
            Random value = new Random((int)DateTime.Now.Second);
           
            TANK[] T34 = new TANK[5];
            for (int i = 0; i < 5; i++)
            {
                //рандом для проверки исключения
                //Random value = new Random((int)DateTime.Now.Second);
                T34[i] = new TANK(value.Next(0, 100), value.Next(0, 100), value.Next(0, 100));

            }
            //Создание такнков пантера
            TANK[] Pantera = new TANK[5];
            for (int i = 0; i < 5; i++)
            {
                //рандом для проверки исключения
                //Random value = new Random((int)DateTime.Now.Second);
                Pantera[i] = new TANK(value.Next(0, 100), value.Next(0, 100), value.Next(0, 100));

            }
            try
            { 
            if (TANK.WAR(T34, Pantera))
            {
                Console.WriteLine("Выгроли танки Т34");
            }
            else
            {
                Console.WriteLine("Выграли пантеры");
            }
            }
            catch (Exception)
            {
                Console.WriteLine("Ничья");
            }
            Console.ReadKey();
        }
        
    }
}

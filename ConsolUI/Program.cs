using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsolUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.ModelYear);
                Console.WriteLine(item.Description);
            }


            Console.WriteLine("--------------------------");
        }
    }
}

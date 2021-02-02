using System;

namespace InterFaces
    //interface newlenmez, o bir şablondur.
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            IPersonManager internManager = new InternManager();
            internManager.Add();
            internManager.Update();
            customerManager.Update();
        }
    }
    interface IPersonManager  //farklı parametler eklendiğinde 1 class ile sisteme entegre olur
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager  //interface şablonuna yapılan her ekleme burda ampulden eklenir(her class için)
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi.");
        }
    }
}

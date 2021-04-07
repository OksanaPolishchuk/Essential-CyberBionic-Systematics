using System;
using System.Collections.Generic;

namespace SalonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator administrator = new Administrator();
            
            Salon salon = new Salon("Lab360", administrator);
            Client client = new Client("Katya Polishchuk", administrator); 
            
            administrator.Services();
            client.StopTrade();

            Console.Read();
        }
    }

    interface IСlient
    {
        void Update(Object ob);
    }

    interface ISalon
    {
        void RegisterObserver(IСlient сlient);
        void RemoveObserver(IСlient сlient);
        void NotifyObservers();
    }

    class Administrator : ISalon
    {
        Notification _notification; // информация о торгах

        List<IСlient> _сlients;

        public Administrator()
        {
            _сlients = new List<IСlient>();
            _notification = new Notification();
        }

        public void RegisterObserver(IСlient сlient)
        {
            _сlients.Add(сlient);
        }

        public void RemoveObserver(IСlient сlient)
        {
            _сlients.Remove(сlient);
        }

        public void NotifyObservers()
        {
            foreach (IСlient сlient in _сlients)
            {
                сlient.Update(_notification);
            }
        }

        public void Services()
        {
            Random rnd = new Random();
            _notification.Manicure = rnd.Next(9, 20);
            _notification.Haircut = rnd.Next(9, 20);
            NotifyObservers();
        }
    }

    class Notification
    {
        public int Manicure { get; set; }
        public int Haircut { get; set; }
    }

    class Client : IСlient
    {
        public string Name { get; set; }
        ISalon salon;

        public Client(string name, ISalon salon)
        {
            Name = name;
            this.salon = salon;
            this.salon.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            Notification notification = (Notification) ob;

            if (notification.Manicure < 18)
                Console.WriteLine("{0}, you enrolled for a manicure at {1}.", this.Name, notification.Manicure);
            else
                Console.WriteLine("{0}, you are not recorded for a manicure", this.Name);
        }

        public void StopTrade()
        {
            salon.RemoveObserver(this);
            salon = null;
        }
    }

    class Salon : IСlient
    {
        public string Name { get; set; }
        ISalon salon;

        public Salon(string name, ISalon salon)
        {
            Name = name;
            this.salon = salon;
            this.salon.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            Notification notification = (Notification) ob;

            if (notification.Haircut < 18)
                Console.WriteLine("You enrolled in the {0} for a haircut at {1}.", this.Name, notification.Haircut);
            else
                Console.WriteLine("Calon {0} do not accepts any appointments for a haircut!", this.Name);
        }
    }
}
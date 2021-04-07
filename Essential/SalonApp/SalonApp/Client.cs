using System;

namespace SalonApp
{
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
}

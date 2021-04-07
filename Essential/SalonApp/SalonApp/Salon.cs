using System;

namespace SalonApp
{
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

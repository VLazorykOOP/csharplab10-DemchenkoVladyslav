using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class Horse
    {
        private string name;
        private int age;

        // Подія, що відбувається, коли кінь народжується
        public event EventHandler Born;

        // Подія, що відбувається, коли кінь повідомляє про свій вік
        public event EventHandler AgeAnnounced;

        // Подія, що відбувається, коли кінь помирає
        public event EventHandler DeathAnnounced;

        public Horse(string name)
        {
            this.name = name;
        }

        // Метод, який викликається, коли кінь народжується
        public void Birth()
        {
            Console.WriteLine($"{name} народився!");
            OnBorn();
        }

        // Метод, який викликається, коли кінь відомляє про свій вік
        public void AnnounceAge(int age)
        {
            this.age = age;
            Console.WriteLine($"{name} має {age} років.");
            OnAgeAnnounced();
        }
        public void Kill()
        {
            OnDeath();
        }
        // Метод для виклику події Born
        protected virtual void OnBorn()
        {
            Born?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnDeath()
        {
            DeathAnnounced?.Invoke(this, EventArgs.Empty);
        }
        // Метод для виклику події AgeAnnounced
        protected virtual void OnAgeAnnounced()
        {
            AgeAnnounced?.Invoke(this, EventArgs.Empty);
        }

    }
}

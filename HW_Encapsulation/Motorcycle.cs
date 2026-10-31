using HW_Encapsulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Encapsulation
{
    internal class Motorcycle
    {
        public int driverlntensity;
        // Новые члены для представления имени водителя,
        public string name;
        public void SetDriverName(string name) => this.name = name;
        public void PopAWheel()
        {
            for (int i = 0; i <= driverlntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }
// Вернуть стандартный конструктор, который будет
// устанавливать все члены данных в стандартные значения.
        public Motorcycle() { }
// Специальный конструктор,
        public Motorcycle(int intensity)
        {
            driverlntensity = intensity;
        }
    }
}

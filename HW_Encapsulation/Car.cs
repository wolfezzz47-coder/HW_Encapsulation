using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Encapsulation
{
    class Car
    {
        // 'Состояние' объекта Саг.
        public string petName;
        public int currSpeed;
        // Специальный стандартный конструктор,
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        // Здесь currSpeed получает стандартное значение для типа int (0).
        public Car(string pn)
        {
            petName = pn;
        }
        // Позволяет вызывающему коду установить полное состояние объекта Саг.
        //public Car(string pn, int сs)
        //{
        //    petName = pn;
        //    currSpeed = cs;
        //}



    }
}

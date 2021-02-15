using System;
using System.Collections.Generic;
using System.Text;

namespace H
{
    class Girl : Human, IHumanShow
    {

        private string name;

        private string surname;

        private string sex;

        private void HI()
        {
            name = "Girl";
            surname = "Girl Surname";
            sex = "Female";
            Console.WriteLine($"Name : {name},\nSurname : {surname},\nSex : {sex},");
        }

        protected override void HO()
        {
            age = 15;
            wight = 20;
            height = 1;
            Console.WriteLine($"age : {age},\nwight : {wight},\nheight : {height}");
        }

        public void Show()
        {
            HI();
            HO();
            Console.WriteLine("");
        }
    }
}

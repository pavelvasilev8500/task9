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
            age = 30;
            wight = 20;
            height = 1;
            Console.WriteLine($"age : {age},\nwight : {wight},\nheight : {height}");
        }

        private void Birth()
        {
            Console.WriteLine("Give birth to a child\n");
        }

        public void Show()
        {
            HI();
            HO();
            Birth();
            Console.WriteLine("");
        }
    }
}

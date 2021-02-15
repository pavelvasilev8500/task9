using System;
using System.Collections.Generic;
using System.Text;

namespace H
{
    class Boy : Human, IHumanShow
    {

        private string name;

        private string surname;

        private string sex;

        private void HI()
        {
            name = "Boy";
            surname = "Boy Surname";
            sex = "Male";
            Console.WriteLine($"Name : {name},\nSurname : {surname},\nSex : {sex},");
        }

        protected override void HO()
        {
            age = 20;
            wight = 60;
            height = 2;
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

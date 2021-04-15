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
            age = 32;
            wight = 60;
            height = 2;
            Console.WriteLine($"age : {age},\nwight : {wight},\nheight : {height}");
        }

        private void Hobby()
        {
            Console.WriteLine("Travel around the World\n");
        }

        public void Show()
        {
            HI();
            HO();
            Hobby();
            Console.WriteLine("");
        }

    }
}

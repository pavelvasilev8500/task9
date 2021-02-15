using System;
using System.Collections.Generic;
using System.Text;

namespace H
{
    class HumanShow
    {
        public void HShow()
        {
            var list = new List<IHumanShow>();
            list.Add(new Boy());
            list.Add(new Girl());
            foreach(var human in list)
            {
                human.Show();
            }
        }
    }
}

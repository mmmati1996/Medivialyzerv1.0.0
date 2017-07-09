using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medivialyzerv1._0._0
{
    class MonstersDrop
    {
        public static List<string> GetMonsterItemList (string nazwa)
        {
            List<string> loocik = new List<string>();
            switch(nazwa)
            {
                case "Monster1":
                    loocik.Add("Axe");
                    loocik.Add("Sword");
                    loocik.Add("Axe");
                    loocik.Add("Sword");
                    loocik.Add("Axe");
                    loocik.Add("Sword");
                    loocik.Add("Axe");
                    loocik.Add("Sword");
                    loocik.Add("Axe");
                    loocik.Add("Sword");
                    break;
                case "Monster2":
                    loocik.Add("Axe");
                    loocik.Add("Axe");
                    loocik.Add("Axe");
                    loocik.Add("Axe");
                    loocik.Add("Axe");
                    break;
                case "Monster3":
                    loocik.Add("Sword");
                    loocik.Add("Sword");
                    loocik.Add("Sword");
                    loocik.Add("Sword");
                    loocik.Add("Sword");
                    loocik.Add("Sword");
                    break;
            }
            return loocik;
        }

    }
}

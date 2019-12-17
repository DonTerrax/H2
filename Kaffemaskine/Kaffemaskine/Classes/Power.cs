using System.Threading;

namespace Kaffemaskine.Classes
{
    class Power
    {
        public bool power = false;
        public string PowerOn(bool powder,double water)
        {
            if (water > 0)
            {
                if (powder)
                {
                    if (power == false)
                    {
                        power = true;
                        TeaFlavor drink = new TeaFlavor();
                        Thread.Sleep(4000);
                        return "Drink is finish";
                    }
                }
                return "No powder";
            }

            return "No water!";
        }

        public string PowerOff()
        {
            return "Power off";
        }
    }
}

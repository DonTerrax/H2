using System.Collections.Generic;

namespace Kaffemaskine.Classes
{
    public class TeaFlavor
    {
        List<string> flavor = new List<string>() { "Strawbarry", " Camille" };

        public string Flavor()
        {
            string txt =" ";
            for (int i = 0; i < flavor.Count; i++)
            {
                txt += i + 1 + ": " + flavor[i] + " ";


            }

            return txt;
        }
    }
}

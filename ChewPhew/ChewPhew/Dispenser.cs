using System;
using System.Collections.Generic;
using System.Text;

namespace ChewPhew
{
    class Dispenser
    {

        public List<Gum> gumList = new List<Gum>();
        public List<double> amountOfGum = new List<double> { 25, 12, 20, 19, 14, 10 };
        public List<Gum>gumoutput = new List<Gum>();
        Random random = new Random();


        private static object instance;
        public static Dispenser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Dispenser();
                }
                return (Dispenser)instance;
            }
        }
        
        public void AddToGumList()
        {
            for (int i = 0; i < GumFactory.Instance.gum.Length; i++)
            {
                for (int j = 0; j < amountOfGum[i]; j++)
                {
                    gumList.Add(GumFactory.Instance.gum[i]);
                }
            }
        }

        public void FindAmount()
        {
            for (int i = 0; i < amountOfGum.Count; i++)
            {
                double procentSum = Math.Round(55.00 / 100 * amountOfGum[i]);

                amountOfGum[i] = procentSum;
            }
        }

        public void PullLever()
        {
            for (int j = 0; j < 3; j++)
            {
                int i = random.Next(0, gumList.Count);
                gumoutput.Add(gumList[i]);
                gumList.RemoveAt(i);
            }
            

        }



    }
}

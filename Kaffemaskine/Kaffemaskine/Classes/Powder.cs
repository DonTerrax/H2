namespace Kaffemaskine.Classes
{
    class Powder
    {
        public bool containPowder = false;
        public int amountOfSpoons = 0;

        public string AddPowder(int amount, bool filter)
        {
            if (filter == false)
            {
                return "Put a filter in first";
            }
            else
            {
                containPowder = true;
                return "Powder added";
            }
        }
        
    }
}

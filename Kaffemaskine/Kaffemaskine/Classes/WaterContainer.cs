namespace Kaffemaskine.Classes
{
    class WaterContainer
    {
        
        public double water;

        public string AddWater(double addWater)
        {
            water += addWater;
            if (water > 150)
            {
                return "full";
            }
            else
            {
                return "Water added";
            }
        }
       

    }
}

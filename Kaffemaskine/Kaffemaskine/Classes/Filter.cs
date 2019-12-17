namespace Kaffemaskine.Classes
{
    class Filter
    {
        public bool filter = false;
        public bool teaBag = false;

        public string AddFilter()
        {
            if (filter == false)
            {
                filter = true;
                return "Filter added";
            }
            else
            {
                return "Already has a filter";
            }
        }

        public string RemoveFilter(bool powder)
        {
            if (filter == true)
            {
                filter = false;
                return "Filter removed";
            }
            else
            {
                return "No filter";
            }
            
        }

    }
}

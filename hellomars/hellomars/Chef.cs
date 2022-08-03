namespace hellomars
{
    class Chef
    {   //super class
        //inheritance
        public void MakeChicken()
        {
            Console.WriteLine("the chef makes chicken");
        }
        
        public void MakeSalad()
        {
            Console.WriteLine("the chef makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("the chef makes bbq ribs");
        }

    }
}
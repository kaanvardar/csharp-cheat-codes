namespace hellomars
{
    class ItalianChef : Chef
    {   //subclass
        //inheritance
        public override void MakeSpecialDish()
        {
            Console.WriteLine("the chef makes chicken parm");
        }
        public void MakePasta()
        {
            Console.WriteLine("the chef makes pasta");
        }

        
    }
}
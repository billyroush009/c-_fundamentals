using System;

namespace C_
{
    public class ItalianChef : Chef
    {
        public void MakePasta(){
            Console.WriteLine("The chef makes pasta");
        }

        //override keyword used so this class takes over the "MakeSpecialDish()" method
        public override void MakeSpecialDish(){
            Console.WriteLine("The Chef makes chicken parmesan");
        }
    }
}
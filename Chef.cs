using System;

namespace C_
{
    public class Chef
    {
        public void MakeChicken(){
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad(){
            Console.WriteLine("The Chef makes salad");
        }

        //virtual keyword used so that sub-classes can override
        public virtual void MakeSpecialDish(){
            Console.WriteLine("The Chef makes bbq ribs");
        }
        
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    interface IDress
    {
        public void Dress();
    }

    class Mannequins : IDress
    {
        public void Dress()
        {
            Console.WriteLine("Mannequins have been created!");
        }
    }


    class BaseDresser : IDress
    {
        protected IDress _d;

        public BaseDresser(IDress d)
        {
            _d = d;
        }

        public void Dress()
        {
            _d.Dress();
        }
    }

    class Clothes : BaseDresser
    {
        public Clothes(IDress d) : base(d)
        {
        }

        public void GetDressed()
        {
            base.Dress();
            Console.WriteLine("The mannequins have been dressed!");
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.ShoppingSample
{
    public interface IItem
    {
        public float CalcPrice();
        
        public void Show();
    }
}
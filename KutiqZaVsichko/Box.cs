using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutiqZaVsichko
{
    public class Box<T>
    {
        private T stoinost;
        public T Stoinost
        {
            get { return stoinost; }
            set { stoinost = value; }
        }
        public Box(T stoinost)
        {
            this.Stoinost = stoinost;
        }
        public override string ToString()
        {
            return $"{this.Stoinost.GetType().FullName}: {this.Stoinost}";
        }
    }
}

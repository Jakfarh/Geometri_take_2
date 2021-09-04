using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_take_2
{
    public class Logic
    {
        private int side_A;

        public int Side_A
        {
            get { return side_A; }
            set { side_A = value; }
        }
        public int Perimeter()
        {
            return side_A * 4;
        }
        public int area()
        {
            return side_A * side_A;
        }
        public Logic()
        {

        }
    }
}

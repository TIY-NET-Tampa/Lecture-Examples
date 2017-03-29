using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Test
    {
        public string Name { set; }

        private int _age;

        public int Age
        {
            get
            {
                if (_age > 40)
                {
                    return 39;
                }
                else
                {

                    return _age;
                }
            }
        }


        public void GrowOld()
        {
            _age++;
        }


    }
}

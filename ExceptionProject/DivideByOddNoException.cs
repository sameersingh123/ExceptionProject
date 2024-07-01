using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
     class DivideByOddNoException:ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Divisor should not be odd number";
            }
        }
    }
}

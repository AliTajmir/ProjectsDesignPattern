using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade
{
   public class fasad
    {
       SystemA systemA;
       SystemB systemB;
       public fasad()
       {
           systemA = new SystemA();
           systemB = new SystemB();
       }
       public void run()
       {
            systemA.operation1();
            systemA.operation2();
            systemB.operation1();
            systemB.operation2();
        }
    }
}

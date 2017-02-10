using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{

   public class ClassEvent
    {
        public event MyDelegate MyEvent = null;
        public void InvokeEvent()
        {  

        MyEvent.Invoke();
           
        }
        

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogica
{
   class Network
   {
      public Network(int element)
      {
            
      }
      public int connect()
      {
         return 0;
      }
      public bool query(int element)
      {
         if (connect() == 0) return true;
         return false;
      }
   }
}

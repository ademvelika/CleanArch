using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
   public interface IRequestUseCase<InpuntRequest,OutPutRequest>
    {

        OutPutRequest Hanlde(InpuntRequest req);
    }
}

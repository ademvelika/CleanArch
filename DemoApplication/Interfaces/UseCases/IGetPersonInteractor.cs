using DemoDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Interfaces.UseCases
{
    public interface IGetPersonInteractor : IRequestUseCase<string, IEnumerable<Person>>
    {
      
    }
}

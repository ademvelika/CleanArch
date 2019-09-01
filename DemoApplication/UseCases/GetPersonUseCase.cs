using DemoApplication.Interfaces.UseCases;
using DemoApplication.Respositories;
using DemoDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.UseCases
{
  
    public class GetPersonUseCase : IGetPersonInteractor
    {
        private readonly IPersonRespository personRespository;
        public GetPersonUseCase(IPersonRespository res)
        {
            personRespository = res;
        }
        public IEnumerable<Person> Hanlde(string req)
        {
            //filter with string
         return   personRespository.GetAll();
        }
    }
}


using DemoApplication.Interfaces.UseCases;
using DemoApplication.Respositories;
using DemoApplication.UseCases;
using DemoInfrastructure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            IPersonRespository res = new PersonRespository();

            IGetPersonInteractor usercase = new GetPersonUseCase(res);
          var result= usercase.Hanlde("");

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}

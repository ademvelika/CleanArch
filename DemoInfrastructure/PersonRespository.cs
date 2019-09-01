using DemoApplication.Respositories;
using DemoDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInfrastructure
{
    public class PersonRespository : IPersonRespository
    {
        public IEnumerable<Person> GetAll()
        {
            return new List<Person> { new Person { Id = 1, Name = "a" }, new Person { Id = 2, Name = "b" } };
        }
    }
}

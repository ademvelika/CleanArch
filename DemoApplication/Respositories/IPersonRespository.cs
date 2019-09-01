using DemoDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Respositories
{
    public interface IPersonRespository
    {

        IEnumerable<Person> GetAll();
    }
}

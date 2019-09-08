using DemoApplication.Respositories;
using DemoDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoInfrastructure.Respository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRespository
    {
        public void Add(DemoDomain.Domain.Customer entity)
        {

        }

        public void AddRange(IEnumerable<DemoDomain.Domain.Customer> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DemoDomain.Domain.Customer> Find(Expression<Func<DemoDomain.Domain.Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public new DemoDomain.Domain.Customer FirstOrDefault()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DemoDomain.Domain.Customer> Get(Expression<Func<DemoDomain.Domain.Customer, bool>> filter = null, Func<IQueryable<DemoDomain.Domain.Customer>, IOrderedQueryable<DemoDomain.Domain.Customer>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public new DemoDomain.Domain.Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public  IEnumerable<DemoDomain.Domain.Customer> GetAllEntity()
        {
            return GetAll().Select(x => new DemoDomain.Domain.Customer
            {
                Id = x.CustomerID,
                Address = x.Address,
                City = x.City,
                CompanyName = x.CompanyName,
                ContactName = x.ContactName
            });
        }

        public void Remove(DemoDomain.Domain.Customer entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(DemoDomain.Domain.Customer entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<DemoDomain.Domain.Customer> entities)
        {
            throw new NotImplementedException();
        }

        public DemoDomain.Domain.Customer SingleOrDefault(Expression<Func<DemoDomain.Domain.Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(DemoDomain.Domain.Customer entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

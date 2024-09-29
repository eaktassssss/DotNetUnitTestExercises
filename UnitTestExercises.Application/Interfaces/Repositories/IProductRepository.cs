using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Core.Entities;

namespace UnitTestExercises.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        bool Add(Product product);
        Product GetById(string id);
        IEnumerable<Product> GetAll();
        bool Update(Product product);
        bool Delete(string id);
    }
}

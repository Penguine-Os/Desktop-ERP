using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_DAL.Data.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void ToevoegenOfAanpassen(T entity);
        T ZoekOpPK<TPrimaryKey>(TPrimaryKey id);
        IEnumerable<T> Ophalen(Expression<Func<T, bool>> voorwaarden);

        IEnumerable<T> Ophalen(params Expression<Func<T, object>>[] includes);

        IEnumerable<T> Ophalen(Expression<Func<T, bool>> voorwaarden,
            params Expression<Func<T, object>>[] includes);
    }
}

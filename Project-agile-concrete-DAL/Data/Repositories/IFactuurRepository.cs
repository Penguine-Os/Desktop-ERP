using Project_agile_concrete_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_DAL.Data.Repositories
{
    public interface IFactuurRepository
    {
        void FactuurAanmaken(Factuur factuur);
        IEnumerable<Factuur> Ophalen(Expression<Func<Factuur, bool>> voorwaarden);

        IEnumerable<Factuur> Ophalen(params Expression<Func<Factuur, object>>[] includes);

        IEnumerable<Factuur> Ophalen(Expression<Func<Factuur, bool>> voorwaarden,
            params Expression<Func<Factuur, object>>[] includes);
    }
}

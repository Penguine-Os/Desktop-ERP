using Project_agile_concrete_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_DAL.Data.Repositories
{
    public interface IKlantRepository
    {
        IEnumerable<Klant> GetAll();
        void Add(Klant entity);
        void Update(Klant entity);
        void Delete(Klant entity);
        void ToevoegenOfAanpassen(Klant entity);
        Klant ZoekOpPK<KlantPrimaryKey>(KlantPrimaryKey id);
        IEnumerable<Klant> Ophalen(Expression<Func<Klant, bool>> voorwaarden);

        IEnumerable<Klant> Ophalen(params Expression<Func<Klant, object>>[] includes);

        IEnumerable<Klant> Ophalen(Expression<Func<Klant, bool>> voorwaarden,
            params Expression<Func<Klant, object>>[] includes);
    }
}

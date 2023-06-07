using Microsoft.EntityFrameworkCore;
using Project_agile_concrete_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_DAL.Data.Repositories
{
    public class KlantRepository : IKlantRepository
    {
        protected ProjectDBContext Context { get; }
        public KlantRepository(ProjectDBContext context) 
        {
            Context= context;
        }
        public void Add(Klant entity)
        {
            Context.Set<Klant>().Add(entity);
        }

        public void Delete(Klant entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public IEnumerable<Klant> GetAll()
        {
            return Context.Set<Klant>().AsNoTracking().ToList();
        }

        public void ToevoegenOfAanpassen(Klant entity)
        {
            Context.Set<Klant>().Update(entity);
        }

        public IEnumerable<Klant> Ophalen(Expression<Func<Klant, bool>> voorwaarden)
        {
            return Ophalen(voorwaarden, null).ToList();
        }

        public IEnumerable<Klant> Ophalen(params Expression<Func<Klant, object>>[] includes)
        {
            return Ophalen(null, includes).ToList();
        }

        public IEnumerable<Klant> Ophalen(Expression<Func<Klant, bool>> voorwaarden, params Expression<Func<Klant, object>>[] includes)
        {
            IQueryable<Klant> query = Context.Set<Klant>().AsNoTracking();
            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            if (voorwaarden != null)
            {
                query = query.Where(voorwaarden);
            }
            return query.ToList();
        }

        public void Update(Klant entity)
        {
            var trackedEntity = Context.Set<Klant>().Local.FirstOrDefault(entry => entry.Id.Equals(entity.Id));
            if (trackedEntity != null)
            {
                //detach
                this.Context.Entry<Klant>(trackedEntity).State = EntityState.Detached;
            }            

            //Track new version
            this.Context.Entry<Klant>(entity).State = EntityState.Modified;
        }

        public Klant ZoekOpPK<KlantPrimaryKey>(KlantPrimaryKey id)
        {
            return Context.Set<Klant>().Find(id);
        }
    }
}

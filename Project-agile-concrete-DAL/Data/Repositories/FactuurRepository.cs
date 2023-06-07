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
    public class FactuurRepository : IFactuurRepository
    {
        protected ProjectDBContext Context { get; }
        public FactuurRepository(ProjectDBContext context)
        {
            Context = context;
        }

        public void FactuurAanmaken(Factuur factuur)
        {

            Factuur temp = new Factuur
            {
                Datum = factuur.Datum,
                KlantId = factuur.KlantId,
                WinkelId = factuur.WinkelId,
                Id = factuur.Id
            };
            Context.Set<Factuur>().Update(temp);
            Context.SaveChanges();
            int factuurId = temp.Id;
            List<ProductFactuur> stukkenLijst = new List<ProductFactuur>();
            foreach (var item in factuur.Producten)
            {
                if (item.ProductId != null)
                {
                    ProductFactuur productFactuurproduct = new ProductFactuur()
                    {
                        ProductId = item.ProductId,
                        FactuurId = factuurId,
                        Hoeveelheid = item.Hoeveelheid
                    };
                    Context.Set<ProductFactuur>().Update(productFactuurproduct);
                }
                else
                {
                    ProductFactuur productFactuurDienst = new ProductFactuur()
                    {
                        DienstId = item.DienstId,
                        FactuurId = factuurId,
                        Hoeveelheid = item.Hoeveelheid
                    };
                    Context.Set<ProductFactuur>().Update(productFactuurDienst);
                }
            }
        }
        public IEnumerable<Factuur> Ophalen(Expression<Func<Factuur, bool>> voorwaarden, params Expression<Func<Factuur, object>>[] includes)
        {
            IQueryable<Factuur> query = Context.Set<Factuur>();
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

        public IEnumerable<Factuur> Ophalen(Expression<Func<Factuur, bool>> voorwaarden)
        {
            return Ophalen(voorwaarden, null).ToList();
        }

        public IEnumerable<Factuur> Ophalen(params Expression<Func<Factuur, object>>[] includes)
        {
            return Ophalen(null, includes).ToList();
        }
    }
}

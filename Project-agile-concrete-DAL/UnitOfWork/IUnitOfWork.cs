using Project_agile_concrete_DAL.Data.Repositories;
using Project_agile_concrete_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_DAL.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IKlantRepository KlantRepo { get; }
        IFactuurRepository FactuurRepo { get; }
        IRepository<Product> ProductRepo { get; }
        IRepository<ProductFactuur> ProductFactuurRepo { get; }
        IRepository<Categorie> CategorieRepo { get; }  
        IRepository<Dienst> DienstRepo { get; }
        IRepository<Winkel> WinkelRepo { get; }
        IRepository<Stock> StockRepo { get; }
        int Save();
    }
}

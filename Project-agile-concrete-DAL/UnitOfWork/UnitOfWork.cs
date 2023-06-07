using Project_agile_concrete_DAL.Data.Repositories;
using Project_agile_concrete_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region attributen

        private IRepository<Product> _productRepo;
        private IKlantRepository _klantRepo;
        private IFactuurRepository _factuurRepo;
        private IRepository<ProductFactuur> _productFactuurRepo;
        private IRepository<Categorie> _categorieRepo;
        private IRepository<Dienst> _dienstRepo;
        private IRepository<Winkel> _winkelRepo;
        private IRepository<Stock> _stockRepo;

        #endregion attributen
        public UnitOfWork(ProjectDBContext ctx) 
        {
            Context = ctx;
        }
        private ProjectDBContext Context { get; }
        #region repositories
        public IKlantRepository KlantRepo
        {
            get
            {
                if (_klantRepo == null)
                {
                    _klantRepo = new KlantRepository(Context);
                }
                return _klantRepo;
            }
        }
        public IRepository<Winkel> WinkelRepo
        {
            get
            {
                if(_winkelRepo == null)
                {
                    _winkelRepo= new Repository<Winkel>(Context);
                }
                return _winkelRepo;
            }
        }

        public IFactuurRepository FactuurRepo
        {
            get
            {
                if (_factuurRepo == null)
                {
                    _factuurRepo = new FactuurRepository(Context);
                }
                return _factuurRepo;
            }
        }

        public IRepository<Product> ProductRepo
        {
            get
            {
                if (_productRepo == null)
                {
                    _productRepo = new Repository<Product>(Context);
                }
                return _productRepo;
            }
        }
        public IRepository<ProductFactuur> ProductFactuurRepo
        {
            get
            {
                if(_productFactuurRepo == null)
                {
                    _productFactuurRepo = new Repository<ProductFactuur>(Context);
                }
                return _productFactuurRepo;
            }
        }

        public IRepository<Categorie> CategorieRepo
        {
            get
            {
                if(_categorieRepo == null)
                    return new Repository<Categorie>(Context);
                return _categorieRepo;
            }
        }
        public IRepository<Dienst> DienstRepo
        {
            get
            {
                if (_dienstRepo == null)
                {
                    _dienstRepo = new Repository<Dienst>(Context);
                }
                return _dienstRepo;
            }
        }
        public IRepository<Stock> StockRepo
        {
            get
            {
                if(_stockRepo == null)
                {
                    _stockRepo = new Repository<Stock>(Context);
                }
                return _stockRepo;
            }
        }
        #endregion repositories
        public void Dispose()
        {
            Context.Dispose();
        }

        public int Save()
        {
            return Context.SaveChanges();
        }
    }
}

using EricsBooks.DataAccess.Repository.IRepository;
using EricsBooks.Models;
using EricsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EricsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {
            var objFromDb = _db.coverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;
                _db.SaveChanges();
            }

        }
    }
}

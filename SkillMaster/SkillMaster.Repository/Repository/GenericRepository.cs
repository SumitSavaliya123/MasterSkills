using Microsoft.EntityFrameworkCore;
using SkillMaster.Model.DataModels;
using SkillMaster.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMaster.Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<T> entities;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            entities = _appDbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return entities.Find(id);
        }
    }
}

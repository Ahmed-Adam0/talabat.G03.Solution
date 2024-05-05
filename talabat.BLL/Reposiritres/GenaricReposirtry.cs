using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using talabat.BLL.Interface;

namespace talabat.BLL.Reposiritres
{
    public class GenricRepository<T> : IGenericReposirty<T> where T : baseentite
    {
        private readonly Storecontext _context;
        public GenricRepository(Storecontext context)
        {
            _context = context;
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }
        //public async Task<IReadOnlyList<T>> GetAllAsync()
        //    => await _context.Set<T>().ToListAsync();


        //public async Task<T> GetById(int id)
        //   => await _context.Set<T>().ToListAsync

    }
}


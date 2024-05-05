using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talabat.BLL.Interface
{
    public  interface IGenericReposirty<T> where T : baseentite
    {
        Task<T> GetById(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}

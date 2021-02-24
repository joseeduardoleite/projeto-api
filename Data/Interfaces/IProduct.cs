using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Interfaces
{
    public interface IProduct : IGeneric<Product>
    {    
        Task<List<Product>> CustomList();
    }
}
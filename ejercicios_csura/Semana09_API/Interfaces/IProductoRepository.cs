using Semana08_API.Models;

namespace Semana09.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetAllAsync();
        Task<Producto> GetByIdAsync(int id);
        Task<Producto> AddAsync(Producto nuevoProducto);
        Task<bool> UpdateAsync(Producto productoActualizado);
        Task<bool> DeleteAsync(int id);
    }
}

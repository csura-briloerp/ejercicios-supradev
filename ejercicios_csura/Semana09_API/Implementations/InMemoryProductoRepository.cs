using Semana08_API.Models;
using Semana09.Interfaces;

namespace Semana09.Implementations
{
    public class InMemoryProductoRepository : IProductoRepository
    {
        private static List<Producto> _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop", Precio = 1200.50m, Disponible = true },
            new Producto { Id = 2, Nombre = "Mouse", Precio = 25.99m, Disponible = true },
            new Producto { Id = 3, Nombre = "Teclado", Precio = 75.00m, Disponible = false }
        };
        private static int _nextId = _productos.Max(p => p.Id) + 1;

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            await Task.Delay(50);
            return _productos.ToList();
        }

        public async Task<Producto> GetByIdAsync(int id)
        {
            await Task.Delay(20);
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public async Task<Producto> AddAsync(Producto nuevoProducto)
        {
            await Task.Delay(30);
            nuevoProducto.Id = _nextId++;
            _productos.Add(nuevoProducto);
            return nuevoProducto;
        }

        public async Task<bool> UpdateAsync(Producto productoActualizado)
        {
            await Task.Delay(30);
            var index = _productos.FindIndex(p => p.Id == productoActualizado.Id);
            if (index == -1) return false;
            _productos[index] = productoActualizado;
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(30);
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto == null) return false;
            _productos.Remove(producto);
            return true;
        }
    }
}

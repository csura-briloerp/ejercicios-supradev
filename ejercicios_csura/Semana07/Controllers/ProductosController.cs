using Microsoft.AspNetCore.Mvc;
using Semana07.Models;

namespace Semana07.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private static List<Producto> _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop", Precio = 1200.50m, Disponible = true },
            new Producto { Id = 2, Nombre = "Mouse", Precio = 25.99m, Disponible = true },
            new Producto { Id = 3, Nombre = "Teclado", Precio = 75.00m, Disponible = false }
        };

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductosAsync()
        {
            await Task.Delay(100); // Espera 100ms sin bloquear el hilo

            return Ok(_productos);
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> GetProducto(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);

            if (producto == null)
            {
                return NotFound(new { message = "Producto no encontrado", errorCode = 404 });
            }

            return Ok(producto);
        }

        [HttpPost]
        public ActionResult<Producto> PostProducto([FromBody] Producto nuevoProducto)
        {
            nuevoProducto.Id = _productos.Max(p => p.Id) + 1;
            _productos.Add(nuevoProducto);

            return CreatedAtAction(nameof(GetProducto), new { id = nuevoProducto.Id }, nuevoProducto);
        }

        [HttpPut("{id}")]
        public IActionResult PutProducto(int id, [FromBody] Producto productoActualizado)
        {
            if (id != productoActualizado.Id)
            {
                return BadRequest(new { message = "ID de la ruta no coincide con el ID del producto actualizado.", errorCode = 400 });
            }

            var productoExistente = _productos.FirstOrDefault(p => p.Id == id);
            if (productoExistente == null)
            {
                return NotFound(new { message = "El producto a actualizar no existe.", errorCode = 404 });
            }

            // Actualizar propiedades.
            productoExistente.Nombre = productoActualizado.Nombre;
            productoExistente.Precio = productoActualizado.Precio;
            productoExistente.Disponible = productoActualizado.Disponible;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProducto(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound(new { message = "El producto a eliminar no existe", errorCode = 404 });
            }

            _productos.Remove(producto);

            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Semana08_API.Models;
using Semana09.Interfaces;

namespace Semana08_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepository _repository;

        public ProductosController(IProductoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductosAsync()
        {
            return Ok(await _repository.GetAllAsync());
        }

        [HttpGet("{id}")]
        [ActionName("GetProducto")]
        public async Task<ActionResult<Producto>> GetProductoAsync(int id)
        {
            var producto = await _repository.GetByIdAsync(id);
            if (producto == null)
            {
                return NotFound(new { message = "El producto buscado no existe", errorCode = 404 });
            }
            return Ok(producto);
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> PostProductoAsync([FromBody] Producto nuevoProducto)
        {
            await  _repository.AddAsync(nuevoProducto);
            return CreatedAtAction("GetProducto", new { id = nuevoProducto.Id }, nuevoProducto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductoAsync(int id, [FromBody] Producto productoActualizado)
        {
            if (id != productoActualizado.Id)
            {
                return BadRequest(new { message = "ID de la ruta no coincide con el ID del producto actualizado.", errorCode = 400 });
            }

            var success = await _repository.UpdateAsync(productoActualizado);
            if (!success)
            {
                return NotFound(new { message = "El producto a actualizar no existe.", errorCode = 404 });
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var success = await _repository.DeleteAsync(id);
            if (!success)
            {
                return NotFound(new { message = "El producto a eliminar no existe", errorCode = 404 });
            }
            return NoContent();
        }
    }
}

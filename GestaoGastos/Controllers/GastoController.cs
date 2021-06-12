using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GestaoGastos.Models;
using GestaoGastos.Data;
using GestaoGastos.Data.Repository;

namespace GestaoGastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastoController : ControllerBase
    {
        private readonly GastoRepository _repository;

        public GastoController(DataContext context)
        {
            _repository = new GastoRepository(context);
        }

        [HttpGet]
        public ActionResult<List<Gasto>> GetGasto()
        {
            return _repository.GetAll();
        }

        [HttpGet ("{id}")]
        public ActionResult<Gasto> GetGastoById(int id)
        {
            return _repository.GetById(id);
        }
        
        [HttpPost]
        public ActionResult<Gasto> CreateGasto([FromBody] Gasto gasto)
        {
            return _repository.Create(gasto);
        }

        [HttpPut]
        public ActionResult<Gasto> UpdateGasto([FromBody] Gasto gasto)
        {
            return _repository.Update(gasto);
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteGasto(int id)
        {
            return _repository.Delete(id);
        }


    }
}

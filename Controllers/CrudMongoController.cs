using ApiMongo.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiMongo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrudMongoController : ControllerBase
    {
  

        private readonly ILogger<CrudMongoController> _logger;
        private readonly IMongoCollection<Inventario> _collection;

        public CrudMongoController(ILogger<CrudMongoController> logger, IMongoClient mongoClient)
        {
            _logger = logger;
            var database = mongoClient.GetDatabase("Universidad"); // Reemplaza "MiBaseDeDatos" con el nombre de tu base de datos
            _collection = database.GetCollection<Inventario>("Inventario"); // Reemplaza "Inventario" con el nombre de tu colección
        }

    

        [HttpPost("InsertarEnMongo")]
        public IActionResult InsertarEnInventario(Inventario item)
        {
            _collection.InsertOne(item);
            return Ok("Dato insertado en MongoDB.");
        }
    }
}

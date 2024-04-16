using MongoDB.Bson;

namespace ApiMongo.Entities
{
    public class Inventario
    {
        public ObjectId Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}

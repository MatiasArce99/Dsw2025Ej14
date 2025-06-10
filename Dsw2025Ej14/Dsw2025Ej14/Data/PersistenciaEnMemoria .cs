using System.Text.Json;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        private List<Product> _products;

        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }

        

        private void LoadProducts()
        {
            var json = File.ReadAllText("..\\..\\..\\products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }) ?? [];
        }
    }
}

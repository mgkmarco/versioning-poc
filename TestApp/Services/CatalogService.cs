using TestApp.Abstractions;
using TestApp.Models;

namespace TestApp.Services
{
    public class CatalogService : ICatalogService
    {
        public CatalogResponseDto FetchCatalog()
        {
            var response = CatalogResponseDto.FakeCatalogResponse();
            
            return null;
        }
    }
}
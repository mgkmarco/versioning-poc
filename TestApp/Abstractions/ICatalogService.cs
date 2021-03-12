using TestApp.Models;

namespace TestApp.Abstractions
{
    public interface ICatalogService
    {
        public CatalogResponseDto FetchCatalog();
    }
}
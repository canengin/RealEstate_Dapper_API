using RealEstate_Dapper_API.Dtos.ProductDtos;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();

        void CreateProduct(CreateProductDto productDto);
        void DeleteProduct(int id);
        void UpdateProduct(UpdateProductDto updateProductDto);
        Task<GetByIdProductDto> GetProduct(int id);
    }
}

using YumBlazor.Data;

namespace YumBlazor.Repository.IRepository
{
    public interface IproductRespository
    {
        public Task<Product> CreateAsync(Product obj);
        public Task<Product> UpdateAsync(Product obj);
        public Task<bool> DeleteAsync(int obj);
        public Task<Product> GetAsync(int id);
        public Task<IEnumerable<Product>> GetAllAsync();
    }
}

using YumBlazor.Data;

namespace YumBlazor.Repository.IRepository
{
    public interface IcategoryRespository
    {
        public Task<Category> CreateAsync(Category obj);
        public Task<Category> UpdateAsync(Category obj);
        public Task<bool> DeleteAsync(int obj);
        public Task<Category> GetAsync(int id);
        public Task<IEnumerable<Category>> GetAllAsync();
    }
}

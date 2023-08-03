using ControlStudentsPayment.Data;
using System.Linq.Expressions;

namespace ControlStudentsPayment.Services
{
    public abstract class AbstractService<T> where T: class, new()
    {
        private readonly DatabaseContext context;

        public AbstractService(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.GetAllAsync<T>();
        }

        public async Task<IEnumerable<T>> GetFileteredAsync(Expression<Func<T, bool>> predicate)
        {
            return await context.GetFileteredAsync<T>(predicate);
        }

        public async Task<T> GetItemByKeyAsync(object primaryKey)
        { 
            return await context.GetItemByKeyAsync<T>(primaryKey);
        }

        public async Task<bool> AddItemAsync(T item)
        {
            return await context.AddItemAsync<T>(item); 
        }

        public async Task<bool> UpdateItemAsync(T item)
        {
            return await context.UpdateItemAsync<T>(item);
        }

        public async Task<bool> DeleteItemAsync(T item) 
        {
            return await context.DeleteItemAsync<T>(item);
        }

        public async Task<bool> DeleteItemByKeyAsync(object primaryKey)
        {
            return await context.DeleteItemByKeyAsync<T>(primaryKey);
        }

    }
}

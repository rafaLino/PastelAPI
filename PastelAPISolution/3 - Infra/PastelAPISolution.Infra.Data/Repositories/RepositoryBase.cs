using System;
using DapperExtensions;
using PastelAPISolution.Domain.Core.Models;
using PastelAPISolution.Domain.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace PastelAPISolution.Infra.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected const string connectionString = "Data Source=.;Initial Catalog=Pastel;Integrated Security=True";

        public virtual async Task<int> AddAsync(TEntity entity)
        {
            using (var connection = new SqlConnection(connectionString))
            {

                var id = await connection.InsertAsync(entity);
                return id;

            }

        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.DeleteAsync(entity);

            }
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return await connection.GetListAsync<TEntity>();

            }
        }

        public virtual async Task<TEntity> GetAsync(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return await connection.GetAsync<TEntity>(id);

            }
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.UpdateAsync(entity);

            }
        }
    }
}

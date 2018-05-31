using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Options;
using Projects.Configuration.Options;
using Projects.Models.ModelInterfaces;

namespace Projects.Models
{
    public class UserRepository : ICrud<UserModel>
    {
        private IOptions<Config> _configuration;
        public UserRepository(IOptions<Config> configuration)
        {
            this._configuration = configuration;
        }

        public void Create(UserModel obj)
        {
            using (SqlConnection conn = new SqlConnection(_configuration.Value.ConnectionString))
            {
            }
        }

        public List<UserModel> GetListOfObjects()
        {
            throw new NotImplementedException();
        }

        public UserModel GetObjectByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserModel obj)
        {
            throw new NotImplementedException();
        }
    }
}

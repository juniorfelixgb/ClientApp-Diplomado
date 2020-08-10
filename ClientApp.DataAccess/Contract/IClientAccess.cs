using ClientApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.DataAccess.Contract
{
    public interface IClientAccess
    {
        Task<List<Client>> ReadData();
        Task<Client> GetClient(int Id);
    }
}

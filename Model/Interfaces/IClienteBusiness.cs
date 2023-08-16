using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IClienteBusiness
    {
        public Cliente Insert(Cliente cliente);
        public List<Cliente> GetAll();
        public Cliente Get(Guid id);
        public bool Delete(Guid id);
        public bool Update(Cliente cliente);
    }
}

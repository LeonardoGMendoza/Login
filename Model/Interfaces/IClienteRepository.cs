using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.Interfaces
{
    public interface IClienteRepository
    {
        public void Insert(Cliente cliente);
        public List<Cliente> GetAll();
        public Cliente? Get(Guid id);
        public void Delete(Guid id);
        public Cliente Update(Cliente cliente);
        public bool CheckIfInserted(Guid id);
    }
}




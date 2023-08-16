using Model.Interfaces;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        public readonly IClienteRepository _clienteRepository;
        public ClienteBusiness(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Cliente Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente Insert(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        //nesta parte nao consigo implementar
        /*
public Cliente Insert(Cliente cliente)
{
   var result = new ClienteValidator().Validate(cliente);

   if (!result.IsValid)
       throw new InvalidClienteException($"Can't create new register: {string.Join(",", result.Errors)}");

   _clienteRepository.Insert(cliente);

   return cliente;
}

public List<Cliente> GetAll()
{
   return _clienteRepository.GetAll();
}


public Cliente Get(Guid id)
{
   Cliente? cliente = _clienteRepository.Get(id);

   if (cliente is null)
       throw new InvalidClienteException($"There is not a book with the id: {id}. Try again.");

   else return cliente;

}

public bool Delete(Guid id)
{
   if (id.Equals(Guid.Empty))
       throw new InvalidClienteException("Please, inform a valid Id.");

   if (!_clienteRepository.CheckIfInserted(id))
       throw new InvalidBookException($"The book with id {id} was not found. Please, try again.");

   _clienteRepository.Delete(id);

   return true;
}

public bool Update(Cliente Cliente)
{
   if (cliente.Id.Equals(Guid.Empty)
       || !_clienteRepository.CheckIfInserted(cliente.Id)
       || !new ClienteValidator().Validate(cliente).IsValid)
       throw new InvalidBookException("Please, inform a valid cliente.");

   _clienteRepository.Update(cliente);

}
*/
    }

}



    
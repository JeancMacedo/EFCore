using eCommerce2.Models;

namespace eCommerce2.API.Repositories
{
    public interface IUsuarioRepository
    {
        /*
         * CRUD - Create, Read/Retrieve, Update e Delete.
         */

        List<Usuario> Get();
        Usuario Get(int id);
        void Add(Usuario usuario);
        Usuario Update(Usuario usuario);
        void Delete(int id);

    }
}

using BCP_BACKEND_JJCQ.Models;

namespace BCP_FRONTEND_JJCQ.Servicios
{
    public interface IServicio_API
    {
        Task<List<Cuenta>> Lista();
        Task<Cuenta> GetById(int id);   

    }
}

namespace Demo.Data.Vuelos
{
    using System.Threading.Tasks;

    interface IVuelosService
    {
        Task<Vuelo[]> ObtenerVuelos();
    }
}

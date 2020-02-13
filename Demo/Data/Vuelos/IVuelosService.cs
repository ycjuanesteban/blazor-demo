namespace Demo.Data.Vuelos
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    interface IVuelosService
    {
        Task<List<Vuelo>> ObtenerVuelos();

        Task<int> GuardarVuelo(Vuelo vuelo);

        Task<Vuelo> ObtenerVuelo(int idvuelo);

        Task<int> ActualizarVuelo(Vuelo vuelo);

        Task EliminarVuelo(int idVuelo);
    }
}

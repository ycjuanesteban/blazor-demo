namespace Demo.Data.Vuelos
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class VuelosService : IVuelosService
    {
        public Task<Vuelo[]> ObtenerVuelos()
        {
            string[] Origenes = new[]
            {
                "Madrid", "Barcelona", "Valencia", "Mallorca", "Bilbao"
            };

            string[] Destino = new[]
            {
                "Medellín", "Bogotá", "Barranquilla", "Cartagena", "Cali"
            };

            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Vuelo
            {
                Destino = Destino[rng.Next(Destino.Length)],
                Origen = Origenes[rng.Next(Origenes.Length)],
                Id = index,
                HoraLlegada = DateTime.Now.AddDays(index),
                HoraSalida = DateTime.Now.AddDays(rng.Next(index, 100))
            }).ToArray());
        }
    }
}

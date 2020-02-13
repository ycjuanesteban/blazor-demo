namespace Demo.Data.Vuelos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class VuelosService : IVuelosService
    {
        public List<Vuelo> Vuelos { get; set; }

        public VuelosService()
        {
            var rng = new Random();
            Vuelos = new List<Vuelo>()
            {
                new Vuelo(){ Id = 1, Destino = "Medellín", Origen = "Madrid", HoraLlegada = DateTime.Now.AddDays(rng.Next(2, 15)), HoraSalida = DateTime.Now.AddDays(rng.Next(2, 15)) },
                new Vuelo(){ Id = 2, Destino = "Bogotá", Origen = "Valencia", HoraLlegada = DateTime.Now.AddDays(rng.Next(2, 15)), HoraSalida = DateTime.Now.AddDays(rng.Next(2, 15)) },
                new Vuelo(){ Id = 3, Destino = "Río de Janeiro", Origen = "París", HoraLlegada = DateTime.Now.AddDays(rng.Next(2, 15)), HoraSalida = DateTime.Now.AddDays(rng.Next(2, 15)) },
                new Vuelo(){ Id = 4, Destino = "Sofía", Origen = "Oporto", HoraLlegada = DateTime.Now.AddDays(rng.Next(2, 15)), HoraSalida = DateTime.Now.AddDays(rng.Next(2, 15)) },
                new Vuelo(){ Id = 5, Destino = "Bucarest", Origen = "Quebec", HoraLlegada = DateTime.Now.AddDays(rng.Next(2, 15)), HoraSalida = DateTime.Now.AddDays(rng.Next(2, 15)) },
                new Vuelo(){ Id = 6, Destino = "Tokio", Origen = "Montreal", HoraLlegada = DateTime.Now.AddDays(rng.Next(2, 15)), HoraSalida = DateTime.Now.AddDays(rng.Next(2, 15)) }
            };
        }

        public Task<List<Vuelo>> ObtenerVuelos()
        {
            Task.Delay(9000);
            return Task.Run(() => Vuelos);
        }

        public Task<int> GuardarVuelo(Vuelo vuelo)
        {
            Task.Delay(9000);
            vuelo.Id = Vuelos.Count + 1;
            Vuelos.Add(vuelo);
            return Task.Run(() => vuelo.Id);
        }

        public Task<Vuelo> ObtenerVuelo(int idvuelo)
        {
            Vuelo vuelo = Vuelos.Where(x => x.Id == idvuelo).FirstOrDefault();
            return Task.Run(() => vuelo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3_Patrones_DanielAlejandroGonzalezGutierrez
{
    public class ConstructorCasa
    {
        public GrupoDispositivos Sala { get; }
        public GrupoDispositivos Cocina { get; }
        public GrupoDispositivos Cuarto { get; }
        public GrupoDispositivos Casa { get; }

        public ConstructorCasa(List<IDispositivo> dispositivos)
        {
            if (dispositivos == null || dispositivos.Count < 7)
                throw new ArgumentException("");

            Sala = new GrupoDispositivos("Sala");
            Sala.AgregarDispositivo(dispositivos[0]);
            Sala.AgregarDispositivo(dispositivos[1]);
            Sala.AgregarDispositivo(dispositivos[2]);

            Cocina = new GrupoDispositivos("Cocina");
            Cocina.AgregarDispositivo(dispositivos[3]);
            Cocina.AgregarDispositivo(dispositivos[4]);

            Cuarto = new GrupoDispositivos("Cuarto");
            Cuarto.AgregarDispositivo(dispositivos[5]);
            Cuarto.AgregarDispositivo(dispositivos[6]);

            Casa = new GrupoDispositivos("Casa");
            Casa.AgregarDispositivo(Sala);
            Casa.AgregarDispositivo(Cocina);
            Casa.AgregarDispositivo(Cuarto);
        }
    }
}

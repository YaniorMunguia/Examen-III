using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {

        
        
    
       
        public string Vuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Pasajero { get; set; }
        public string Piloto { get; set; }
        public string Salida { get; set; }
        public string Llegada { get; set; }
        public string Fecha { get; set; }





        public Usuario() { }

        public Usuario(string Vuelo, string Origen, string Destino, string Pasajero, string Piloto,string Salida, string Llegada, string fecha)
        {
            this.Vuelo = Vuelo;
            this.Origen = Origen;
            this.Destino = Destino;
            this.Pasajero = Pasajero;
            this.Piloto = Piloto;
            this.Salida = Salida;
            this.Llegada = Llegada;
            this.Fecha = Fecha;
            
        }

        public Usuario(string vuelo, string destino)
        {
            Vuelo = vuelo;
            Destino = destino;
        }
    }
}

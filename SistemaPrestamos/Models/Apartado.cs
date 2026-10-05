using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPresatamos.Models

{
   
    internal class Apartado : EntidadBase, IAlmacenamientoCRUD
    {
        //Lista y Queue de apartados
        private static List<Apartado> _tabla = new List<Apartado>();
        // Conserva solicitudes pendientes FIFO.
        private Queue<Apartado> _colaEspera;

        private DateTime _fechaSolicitud;
        private DateTime _fechaReserva;
        private string _rutaImagen = "default_apartado.png";

        public Apartado() : base()
        {
            // Inicializa la cola vacía.
            _colaEspera = new Queue<Apartado>();
            _fechaSolicitud = DateTime.Now;
            _fechaReserva = DateTime.Now.AddDays(3);
            _rutaImagen = "default_apartado.png";
        }

        public Apartado(int id, DateTime fechaSolicitud, DateTime fechaReserva, string rutaImagen, DateTime fechaRegistro, bool esActivo)
            : base(id, fechaRegistro, esActivo)
        {
            // Inicializa la cola vacía.
            _colaEspera = new Queue<Apartado>();
            FechaSolicitud = fechaSolicitud;
            FechaReserva = fechaReserva;
            RutaImagen = rutaImagen;
        }

        // Expone la cola sin reemplazarla.
        public Queue<Apartado> ColaEspera { get { return _colaEspera; } }

        public DateTime FechaSolicitud { get { return _fechaSolicitud; } set { _fechaSolicitud = value; } }
        public DateTime FechaReserva
        {
            get { return _fechaReserva; }
            set { if (value < _fechaSolicitud) throw new ArgumentException("Error de fecha."); _fechaReserva = value; }
        }
        public string RutaImagen { get { return _rutaImagen; } set { _rutaImagen = string.IsNullOrWhiteSpace(value) ? "default_apartado.png" : value.Trim(); } }

        public override string ToString() { return $"Apartado #{Id} - Solicitud: {_fechaSolicitud.ToShortDateString()} | Reserva: {_fechaReserva.ToShortDateString()}"; }

        public bool ValidarAnticipacionApartado() { return (this._fechaReserva - this._fechaSolicitud).Days >= 3; }
        public bool ValidarAnticipacionApartado(DateTime fechaHoraLimiteEntrega) { if (!this.EsActivo) return false; return DateTime.Now <= fechaHoraLimiteEntrega; }

        // Agrega solicitud al final FIFO.
        public void Encolar(Apartado apartado)
        {
            if (apartado == null)
            {
                throw new ArgumentNullException(nameof(apartado));
            }

            _colaEspera.Enqueue(apartado);
        }

        // Retira el primer apartado pendiente.
        public Apartado AtenderSiguiente()
        {
            if (_colaEspera.Count == 0)
            {
                throw new InvalidOperationException("No hay apartados pendientes para atender.");
            }

            return _colaEspera.Dequeue();
        }

        // Consulta el frente sin retirarlo.
        public Apartado ConsultarSiguiente()
        {
            if (_colaEspera.Count == 0)
            {
                throw new InvalidOperationException("No hay apartados pendientes para consultar.");
            }

            return _colaEspera.Peek();
        }

        // Devuelve solicitudes pendientes en cola.
        public int ObtenerCantidadEnEspera()
        {
            return _colaEspera.Count;
        }

        // Busca el ID entre solicitudes.
        public bool ExisteEnCola(int idApartado)
        {
            foreach (Apartado apartado in _colaEspera)
            {
                if (apartado.Id == idApartado)
                {
                    return true;
                }
            }

            return false;
        }

        // Elimina todas las solicitudes pendientes.
        public void VaciarCola()
        {
            _colaEspera.Clear();
        }

        // Copia la cola conservando orden FIFO.
        public Apartado[] ObtenerApartadosEnEspera()
        {
            Apartado[] apartados = new Apartado[_colaEspera.Count];
            _colaEspera.CopyTo(apartados, 0);
            return apartados;
        }

        public void InsertarRegistro(object objeto) { _tabla.Add((Apartado)objeto); }
        public object ConsultarRegistro(string id) { int idB = int.Parse(id); return _tabla.FirstOrDefault(x => x.Id == idB); }
        public void ActualizarRegistro(object objeto)
        {
            var act = (Apartado)objeto; var ext = (Apartado)ConsultarRegistro(act.Id.ToString());
            if (ext != null) { ext.FechaSolicitud = act.FechaSolicitud; ext.FechaReserva = act.FechaReserva; ext.RutaImagen = act.RutaImagen; ext.EsActivo = act.EsActivo; }
        }
        public void EliminarRegistro(string id) { var ext = (Apartado)ConsultarRegistro(id); if (ext != null) _tabla.Remove(ext); }
    }
}



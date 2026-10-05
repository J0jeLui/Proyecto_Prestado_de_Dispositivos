using System;

namespace SistemaPresatamos.Models
{
    // Clase base abstracta 
    //Centraliza los atributos comunes para los modelos
    public abstract class EntidadBase
    {
        // Atributos heredables comunes para todos los modelos
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool EsActivo { get; set; }

        // Constructor que inicializa valores base
        protected EntidadBase()
        {
            Id = 0;
            FechaRegistro = DateTime.Now;
            EsActivo = true;
        }

        // Constructor parametrizado para inicializar la entidad con datos específicos
        protected EntidadBase(int id, DateTime fechaRegistro, bool esActivo)
        {
            Id = id;
            FechaRegistro = fechaRegistro;
            EsActivo = esActivo;
        }
    }
}



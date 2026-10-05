using System;

namespace SistemaPresatamos.Models
{
    // Interfaz que define el contrato obligatorio para las operaciones CRUD
    public interface IAlmacenamientoCRUD
    {
        void InsertarRegistro(object objeto);
        object ConsultarRegistro(string id);
        void ActualizarRegistro(object objeto);
        void EliminarRegistro(string id);
    }
}
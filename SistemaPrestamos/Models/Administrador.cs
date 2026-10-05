using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPresatamos.Models
{
    public class Administrador : EntidadBase, IAlmacenamientoCRUD
    {
        // Lista estática para simular el almacenamiento en memoria
        private static List<Administrador> _tabla = new List<Administrador>();

        // Campos privados para los datos del administrador
        private string _correo = string.Empty;
        private string _nombre = string.Empty;
        private string _contrasena = string.Empty;
        private string _rutaImagen = "default_admin.png";

        // Constructor que invoca al de la clase base
        public Administrador() : base() { }

        // Constructor con parametros 
        public Administrador(int id, string correo, string nombre, string contrasena, string rutaImagen, DateTime fechaRegistro, bool esActivo)
            : base(id, fechaRegistro, esActivo)
        {
            Correo = correo; Nombre = nombre; Contrasena = contrasena; RutaImagen = rutaImagen;
        }

        // Propiedades con validaciones encapsuladas
        public string Correo { get { return _correo; } set { if (string.IsNullOrWhiteSpace(value) || !value.Contains("@")) throw new ArgumentException("Inválido."); _correo = value.Trim(); } }
        public string Nombre { get { return _nombre; } set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Vacío."); _nombre = value.Trim(); } }
        public string Contrasena { get { return _contrasena; } set { if (string.IsNullOrWhiteSpace(value) || value.Length < 6) throw new ArgumentException("Corto."); _contrasena = value; } }
        public string RutaImagen { get { return _rutaImagen; } set { _rutaImagen = string.IsNullOrWhiteSpace(value) ? "default_admin.png" : value.Trim(); } }

        // toString
        public override string ToString() { return $"Administrador: {_nombre} (Correo: {_correo}) - Activo: {EsActivo}"; }

        // Valida si el objeto actual tiene credenciales activas
        public bool ValidarCredenciales() { return !string.IsNullOrEmpty(this._correo) && !string.IsNullOrEmpty(this._contrasena) && this.EsActivo; }

        // Valida credenciales ingresadas comparándolas con las almacenadas
        public bool ValidarCredenciales(string correoIngresado, string contrasenaIngresada)
        {
            if (!this.EsActivo) return false; return this._correo.Equals(correoIngresado.Trim(), StringComparison.OrdinalIgnoreCase) && this._contrasena.Equals(contrasenaIngresada);
        }




        // Inserta un registro casteando el objeto a la lista en memoria
        public void InsertarRegistro(object objeto) { 
            _tabla.Add((Administrador)objeto); 
        }


        // Consulta un registro buscando por su ID
        public object ConsultarRegistro(string id) {
            int idB = int.Parse(id); return _tabla.FirstOrDefault(x => x.Id == idB);
        }


        // Actualiza los datos de un registro existente en la lista
        public void ActualizarRegistro(object objeto)
        {
            var act = (Administrador)objeto; var ext = (Administrador)ConsultarRegistro(act.Id.ToString());
            if (ext != null) { ext.Correo = act.Correo; ext.Nombre = act.Nombre; ext.Contrasena = act.Contrasena; ext.RutaImagen = act.RutaImagen; ext.EsActivo = act.EsActivo; }
        }

        // Elimina un registro de la lista buscando por su ID
        public void EliminarRegistro(string id) { var ext = (Administrador)ConsultarRegistro(id); if (ext != null) _tabla.Remove(ext); }
    }
}


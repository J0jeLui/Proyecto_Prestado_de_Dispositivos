using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPresatamos.Models
{
    internal interface IPanelCRUD
    {


        void EjecutarGuardar();

        void EjecutarBuscar(string id, ErrorProvider alerta);

        void EjecutarActualizar();

        void EjecutarEliminar(StatusStrip barraEstado);

    }
}

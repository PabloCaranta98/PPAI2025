using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025.Entidades
{
    public class OrdenInspeccion
    {
        // Atributos clase
        private int nroOrden;
        private string observacionCierre;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraCierre;
        private DateTime fechaHoraFinalizacion;

        // Atributos de referencia
        private Estado Estado;
        private Empleado Empleado;
        private EstacionSismologica EstacionSismologica;


        // Constructor
        public OrdenInspeccion(int nroOrd, string obsCierre, DateTime fechaHIni, DateTime fechaHCierre, DateTime fechaHFinaliz)
        {
            nroOrden = nroOrd;
            observacionCierre = obsCierre;
            fechaHoraCierre = fechaHCierre;
            fechaHoraInicio = fechaHIni;
            fechaHoraFinalizacion = fechaHFinaliz;
        }

        public int NroOrden { get { return nroOrden;} set { nroOrden = value; } }
        public string ObservacionCierre { get { return observacionCierre; } set { observacionCierre = value; } }
        public DateTime FechaHoraInicio { get { return fechaHoraInicio; } set { fechaHoraInicio = value; } } 
        public DateTime FechaHoraCierre { get { return fechaHoraCierre; } set { fechaHoraInicio = value; } }
        public DateTime FechaHoraFinalizacion { get { return fechaHoraFinalizacion; } set {fechaHoraFinalizacion = value; } }
        public Estado Estado { get { return Estado; } set { Estado = value; } }
        public Empleado Empleado { get { return Empleado; } set { Empleado = value; } }
        public EstacionSismologica EstacionSismologica { get { return   EstacionSismologica; } set { EstacionSismologica = value; } }


    }

}

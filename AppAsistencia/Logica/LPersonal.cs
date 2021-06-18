using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAsistencia.Logica
{
    public class lPersonal
    {
        //Creacion de  las Variables de la Entidad Logica de lPersonal
        int id_Personal;
        string nombrePersonal;
        string identificacionPersonal;
        string paisPersonal;
        int id_CargoPersonal;
        double sueldoPorHoraPersonal;
        string estadoPersonal;
        string codigoPersonal;

        public int Id_Personal
        {
            get
            {
                return id_Personal;
            }

            set
            {
                id_Personal = value;
            }
        }

        public string NombrePersonal
        {
            get
            {
                return nombrePersonal;
            }

            set
            {
                nombrePersonal = value;
            }
        }

        public string IdentificacionPersonal
        {
            get
            {
                return identificacionPersonal;
            }

            set
            {
                identificacionPersonal = value;
            }
        }

        public string PaisPersonal
        {
            get
            {
                return paisPersonal;
            }

            set
            {
                paisPersonal = value;
            }
        }

        public int Id_CargoPersonal
        {
            get
            {
                return id_CargoPersonal;
            }

            set
            {
                id_CargoPersonal = value;
            }
        }

        public double SueldoPorHoraPersonal
        {
            get
            {
                return sueldoPorHoraPersonal;
            }

            set
            {
                sueldoPorHoraPersonal = value;
            }
        }

        public string EstadoPersonal
        {
            get
            {
                return estadoPersonal;
            }

            set
            {
                estadoPersonal = value;
            }
        }

        public string CodigoPersonal
        {
            get
            {
                return codigoPersonal;
            }

            set
            {
                codigoPersonal = value;
            }
        }
    }
}

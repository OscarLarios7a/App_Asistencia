using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAsistencia.Logica
{
    public class LCargo
    {
        int id_Cargo;
        string nombreCargo;
        double sueldoCargo;

        public int Id_Cargo
        {
            get
            {
                return id_Cargo;
            }

            set
            {
                id_Cargo = value;
            }
        }

        public string NombreCargo
        {
            get
            {
                return nombreCargo;
            }

            set
            {
                nombreCargo = value;
            }
        }

        public double SueldoCargo
        {
            get
            {
                return sueldoCargo;
            }

            set
            {
                sueldoCargo = value;
            }
        }
    }
}

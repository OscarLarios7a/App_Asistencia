using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAsistencia.Logica
{
    //se Genera la clase de LPersonal para evitar errores al llamarla desde otra capa por ello se le pone "public class"
    public class LPersonal
   {
        //        [Id_personal]
        //        [int] IDENTITY(1,1) NOT NULL,

        //[Nombres] [varchar](max) NULL,
        //	[Identificacion]
        //        [varchar](max) NULL,
        //	[Pais]
        //        [varchar](max) NULL,
        //	[Id_cargo]
        //        [int] NULL,
        //	[SueldoPorHora]
        //        [numeric](18, 2) NULL,
        //	[Estado]
        //        [varchar](max) NULL,
        //	[codigo]
        //        [varchar](max) NULL,
        public int Id_personal { get; set; }
        public string Nombres { get; set; }


    }
}

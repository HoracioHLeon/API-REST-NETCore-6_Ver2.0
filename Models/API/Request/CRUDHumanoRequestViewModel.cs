using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API.Request
{
    public class CRUDHumanoRequestViewModel
    {
        //public int intAccion { get; set; }
        //public int intHumanoKey { get; set; }
        public string vchNombre { get; set; }
        public string vchPrimerApellido { get; set; }
        public string vchSegundoApellido { get; set; }
        public string intGeneroLink { get; set; }
        public int intEdad { get; set; }
        public double fltAltura { get; set; }
        public double fltPeso { get; set; }
        public int intErrorNumber { get; set; }
        public string vchErrorMessage { get; set; }
    }
}

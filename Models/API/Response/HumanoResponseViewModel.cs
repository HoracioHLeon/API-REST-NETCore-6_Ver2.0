using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API.Response
{
    public class HumanoResponseViewModel
    {
		public HumanoResponseViewModel() { }
        public int intHumanoKey { get; set; }
        public string vchNombre { get; set; }
        public string vchPrimerApellido { get; set; }
        public string vchSegundoApellido { get; set; }
        public string vchNombreCompleto { get; set; }
        public string vchGenero { get; set; }
        public int intEdad { get; set; }
        public double fltAltura { get; set; }
        public double fltPeso { get; set; }
	}
}

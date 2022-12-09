using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA___priprema.Models
{
    public class KlasaOsiguranja
    {
        public int id { get; set; }
        public string nazivKlase { get; set; }
        public int faktorOsiguraneSume { get; set; }
        public int faktorCijene { get; set; }
        public bool? ugovorena { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA___priprema.Models
{
    public class VrstaOsiguranja
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public float osiguranaSumaPoUsluzi { get; set; }
        public float cijena { get; set; }
        public string icon { get; set; }
        public bool? ugovorena { get; set; }
        public float? kolicina { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public partial class Bestrahlung
    {
        public Datum Datum { get; set; }

        public Applikationsart Applikationsart { get; set; }
        //public Bestrahlung_Applikationsart_Typ Applikationsart { get; set; }

        public Dauer Anzahl_Tage_Diagnose_ST { get; set; }

        public Dauer Anzahl_Tage_ST_Dauer { get; set; }
    }
}
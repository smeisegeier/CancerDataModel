using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public class OP
    {

        public Datum Datum { get; set; }

        public OP_Intention_Typ Intention { get; set; }

        //[System.Xml.Serialization.XmlArrayItem("OPS", IsNullable = false)]
        public List<OPS> Menge_OPS { get; set; }
        
        public Residualstatus Residualstatus { get; set; }

        public Dauer Anzahl_Tage_Diagnose_OP { get; set; }

    }
}
using Rki.CancerDataModel.Models.Dimensions;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public partial class Tod : AdtgekidBase
    {
        public Datum Sterbedatum { get; set; }

        [XmlArrayItem("Todesursache_ICD")]
        public List<Allgemein_ICD> Menge_Weitere_Todesursachen { get; set; }

        public Allgemein_ICD Grundleiden { get; set; }

    }
}
using Rki.CancerDataModel.Models.Dimensions;
using System.Xml.Serialization;

namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public class Folgeereignis : AdtgekidBase
    {
        public TNM TNM { get; set; }

        [XmlArrayItem("Weitere_Klassifikation", IsNullable = false)]
        public Weitere_Klassifikation[] Menge_Weitere_Klassifikation { get; set; }
        
        public Datum Untersuchungsdatum_Verlauf { get; set; }

        public Gesamtbeurteilung_Tumorstatus_Typ Gesamtbeurteilung_Tumorstatus { get; set; }

        public Verlauf_Lokaler_Tumorstatus_Typ Verlauf_Lokaler_Tumorstatus { get; set; }

        public Verlauf_Tumorstatus_Lymphknoten_Typ Verlauf_Tumorstatus_Lymphknoten { get; set; }

        public Verlauf_Tumorstatus_Fernmetastasen_Typ Verlauf_Tumorstatus_Fernmetastasen { get; set; }

        [XmlArrayItem("Fernmetastase", IsNullable = false)]
        public Fernmetastase[] Menge_FM { get; set; }

        [XmlAttribute()]
        public string Verlauf_ID { get; set; }
    }
}
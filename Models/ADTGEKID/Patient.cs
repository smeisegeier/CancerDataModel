using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataModel.Models.Dimensions;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public class Patient : AdtgekidBase
    {

        public Patient() { }

        public Patienten_Stammdaten Patienten_Stammdaten { get; set; }
       
        public List<Tumor> Menge_Tumor { get; set; }

        [XmlAttribute]
        public string Patient_ID { get; set; }
    }
}
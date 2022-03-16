﻿using System.Xml.Serialization;

namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public class Lieferregister
    {

        [XmlAttribute]
        public ISO3199_2_Typ Bundesland_ID { get; set; }


        [XmlAttribute]
        public string Software_ID { get; set; }


        [XmlAttribute]
        public string Installations_ID { get; set; }
    }
}
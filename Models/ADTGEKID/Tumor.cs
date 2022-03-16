﻿using Rki.CancerDataModel.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public class Tumor : AdtgekidBase
    {
        [XmlAttribute()]
        public string Tumor_ID { get; set; }

        public Diagnose Primaerdiagnose { get; set; }

        public List<OP> Menge_OP { get; set; }

        public ST[] Menge_ST { get; set; }

        public SYST[] Menge_SYST { get; set; }

        [XmlArrayItem("Folgeereignis")]
        public List<Verlauf> Menge_Folgeereignis { get; set; }

    }
}
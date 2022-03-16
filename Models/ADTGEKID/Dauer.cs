using System;
using System.Xml.Serialization;

namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public class Dauer
    {
        public Dauer(){}

        public Dauer(int days, JNU_Typ type)
        {
            Value = days;
            JNU = type.ToString();
        }

        [XmlAttribute]
        public string JNU { get; set; } 


        [XmlText]
        public int Value { get; set; } 

    }
}
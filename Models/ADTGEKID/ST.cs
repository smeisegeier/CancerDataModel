﻿namespace Rki.CancerDataModel.Models.ADTGEKID
{
    public class ST
    {
        public ST_Intention_Typ Intention { get; set; }

        public ST_Stellung_OP_Typ Stellung_OP { get; set; }

        public Bestrahlung[] Menge_Bestrahlung { get; set; }
       
    }
}
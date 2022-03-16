﻿namespace Rki.CancerDataModel.Models.Dimensions
{
    public class TherapyTime : DimensionBase
    {
        public string therapy_time_relation_id { get; set; }
        public string therapy_time_relation_shortname { get; set; }
        public string therapy_time_relation_longname_english { get; set; }
        public string therapy_time_relation_longname_german { get; set; }
        public int therapy_time_relation_ordinal { get; set; }

    }
}

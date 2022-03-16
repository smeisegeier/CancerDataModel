using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rki.CancerDataModel.Models
{

    /// <summary>
    /// Base for Dimension classes.
    /// SQL table data source: [zfkdsql01].[KKrModel_RKI]
    /// </summary>
    public abstract class DimensionBase : AdtgekidBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }
    }
}

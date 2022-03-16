using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Rki.CancerDataModel
{
    public static class Globals
    {
        public const string PROJECTVERSION = "3.0.0.5.1";
        public const string XSDFILENAME = "ADT_GEKID_v3.0.0.5_RKI.xsd";
        public const string XSDPATHRELATIVE = "Schemas/" + XSDFILENAME;

        public const string XSDNAMESPACE = "http://www.gekid.de/namespace";
        public const string XSINAMESPACE = "http://www.w3.org/2001/XMLSchema-instance";
    }
}

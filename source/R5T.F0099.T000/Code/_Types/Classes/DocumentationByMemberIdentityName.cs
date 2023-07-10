using System;
using System.Collections.Generic;

using R5T.T0142;
using R5T.T0162;
using R5T.T0173;


namespace R5T.F0099.T000
{
    /// <summary>
    /// Represents the XML description data inside an compilation output documentaion file.
    /// </summary>
    [DataTypeMarker]
    public class DocumentationByMemberIdentityName
    {
        public Dictionary<IIdentityName, IDescriptionXml> Value { get; set; }
    }
}

using System;
using System.Collections.Generic;

using R5T.T0132;
using R5T.T0162;
using R5T.T0173;


namespace R5T.F0099.T000
{
    [FunctionalityMarker]
    public partial interface IDictionaryOperator : IFunctionalityMarker
    {
        public DocumentationByMemberIdentityName ToDocumentationByMemberIdentityName(
            Dictionary<IdentityName, DescriptionXml> value)
        {
            var output = new DocumentationByMemberIdentityName
            {
                Value = value
            };

            return output;
        }
    }
}

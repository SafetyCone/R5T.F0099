using System;
using System.Collections.Generic;

using R5T.T0162;
using R5T.T0173;


namespace R5T.F0099.T000.Extensions
{
    public static class DictionaryExtensions
    {
        public static DocumentationByMemberIdentityName ToDocumentationByMemberIdentityName(
            this Dictionary<IdentityName, DescriptionXml> value)
        {
            return Instances.DictionaryOperator.ToDocumentationByMemberIdentityName(value);
        }
    }
}

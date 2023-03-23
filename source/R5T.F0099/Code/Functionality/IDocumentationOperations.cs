using System;
using System.Linq;

using R5T.T0132;

using R5T.T0162.Extensions;
using R5T.T0172;
using R5T.T0173.Extensions;

using R5T.F0099.T000;
using R5T.F0099.T000.Extensions;


namespace R5T.F0099
{
    [FunctionalityMarker]
    public partial interface IDocumentationOperations : IFunctionalityMarker
    {
        private static F001.IDocumentationOperations StringlyTypedOperations => F001.DocumentationOperations.Instance;


        public DocumentationByMemberIdentityName GetDocumentationByMemberIdentityName(
            IDocumentationXmlFilePath documentationXmlFilePath)
        {
            var documentationByMemberIdentityName = StringlyTypedOperations.GetDocumentationByMemberIdentityName(
                documentationXmlFilePath.Value);

            // Create strongly-typed type.
            var output = documentationByMemberIdentityName
                .ToDictionary(
                    x => x.Key.ToIdentityName(),
                    x => x.Value.ToDescriptionXml())
                .ToDocumentationByMemberIdentityName();

            return output;
        }
    }
}

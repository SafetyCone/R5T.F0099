using System;
using System.Collections.Generic;
using System.Xml.XPath;

using R5T.T0132;


namespace R5T.F0099.F001
{
    /// <summary>
    /// Stringly-typed XML documentation operations.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IDocumentationOperations : IFunctionalityMarker
    {
        public Dictionary<string, string> GetDocumentationByMemberIdentityName(
            string documentationXmlFilePath)
        {
            var output = new Dictionary<string, string>();

            var documentationFileExists = Instances.FileSystemOperator.FileExists(documentationXmlFilePath);
            if (documentationFileExists)
            {
                var documentation = Instances.XmlOperator.Load_XDocument(documentationXmlFilePath);

                var membersNode = documentation.XPathSelectElement(Instances.XPaths.DocumentationMembersNode_FromRoot);

                var membersNodeExists = membersNode is object;
                if (membersNodeExists)
                {
                    var memberNodes = membersNode.XPathSelectElements(Instances.XPaths.MemberNodes_FromMembersNode);
                    foreach (var memberNode in memberNodes)
                    {
                        var memberIdentityName = memberNode.Attribute(Instances.AttributeNames.Name).Value;
                        var documentationForMember = memberNode.FirstNode.ToString();

                        var prettyPrintedDocumentationForMember = Instances.DocumentationOperator.PrettyPrint(documentationForMember);

                        output.Add(memberIdentityName, prettyPrintedDocumentationForMember);
                    }
                }
            }

            return output;
        }
    }
}

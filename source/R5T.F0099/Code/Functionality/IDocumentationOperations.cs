using System;
using System.Collections.Generic;
using System.Xml.XPath;

using R5T.T0132;


namespace R5T.F0099
{
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

                var membersNode = documentation.XPathSelectElement("//doc/members");

                var membersNodeExists = membersNode is object;
                if (membersNodeExists)
                {
                    var memberNodes = membersNode.XPathSelectElements("member");
                    foreach (var memberNode in memberNodes)
                    {
                        var memberIdentityName = memberNode.Attribute("name").Value;
                        var documentationForMember = memberNode.FirstNode.ToString();

                        var prettyPrintedDocumentationForMember = DocumentationOperator.Instance.PrettyPrint(documentationForMember);

                        output.Add(memberIdentityName, prettyPrintedDocumentationForMember);
                    }
                }
            }

            return output;
        }
    }
}

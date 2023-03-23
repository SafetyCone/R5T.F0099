using System;
using System.Text.RegularExpressions;

using R5T.T0132;


namespace R5T.F0099.F001
{
    [FunctionalityMarker]
    public partial interface IDocumentationOperator : IFunctionalityMarker
    {
        public string PrettyPrint(string documentationXml)
        {
            var regexPattern = "\n +";

            var output = Regex.Replace(
                documentationXml,
                regexPattern,
                "\n");

            return output;
        }
    }
}

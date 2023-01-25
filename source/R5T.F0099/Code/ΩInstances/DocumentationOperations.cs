using System;


namespace R5T.F0099
{
    public class DocumentationOperations : IDocumentationOperations
    {
        #region Infrastructure

        public static IDocumentationOperations Instance { get; } = new DocumentationOperations();


        private DocumentationOperations()
        {
        }

        #endregion
    }
}

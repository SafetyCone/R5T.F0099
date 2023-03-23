using System;


namespace R5T.F0099.F001
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

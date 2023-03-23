using System;


namespace R5T.F0099.F001
{
    public static class Instances
    {
        public static IAttributeNames AttributeNames => F001.AttributeNames.Instance;
        public static IDocumentationOperator DocumentationOperator => F001.DocumentationOperator.Instance;
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static F0000.IXmlOperator XmlOperator => F0000.XmlOperator.Instance;
        public static IXPaths XPaths => F001.XPaths.Instance;
    }
}
using System;


namespace R5T.F0099
{
    public static class Instances
    {
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static F0000.IXmlOperator XmlOperator => F0000.XmlOperator.Instance;
    }
}
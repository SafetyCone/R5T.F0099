using System;


namespace R5T.F0099.F001
{
    public class XPaths : IXPaths
    {
        #region Infrastructure

        public static IXPaths Instance { get; } = new XPaths();


        private XPaths()
        {
        }

        #endregion
    }
}

using System;

using R5T.T0131;


namespace R5T.F0099.F001
{
    [ValuesMarker]
    public partial interface IXPaths : IValuesMarker
    {
        public string DocumentationMembersNode_FromRoot => "//doc/members";
        public string MemberNodes_FromMembersNode => "member";
    }
}

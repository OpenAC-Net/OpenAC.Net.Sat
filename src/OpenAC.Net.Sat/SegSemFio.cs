using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.Sat
{
    public enum SegSemFio
    {
        [DFeEnum("")]
        None,

        [DFeEnum("WEP")]
        Wep,

        [DFeEnum("WPA-PERSONAL")]
        WpaPersonal,

        [DFeEnum("WPA-ENTERPRISE")]
        WpaEnterprise
    }
}
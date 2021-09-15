using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.Sat
{
    public enum TipoLan
    {
        [DFeEnum("DHCP")]
        DHCP,

        [DFeEnum("PPPoE")]
        PPPoE,

        [DFeEnum("IPFIX")]
        IPFIX
    }
}
using OpenAC.Net.DFe.Core.Attributes;

namespace OpenAC.Net.Sat
{
    public enum TipoInterface
    {
        [DFeEnum("ETHE")]
        Lan,

        [DFeEnum("WIFI")]
        Wifi
    }
}
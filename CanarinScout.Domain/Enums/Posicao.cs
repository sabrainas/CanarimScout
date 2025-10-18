using System.ComponentModel;

namespace CanarinScout.Domain.Enums
{
    public enum Posicao
    {
        [Description("Desconhecido")]
        Desconhecido,
        [Description("Goleiro")]
        GK,
        [Description("Defensor")]
        DF,
        [Description("Meio-campo")]
        MF,
        [Description("Atacante")]
        FW,
    }
}

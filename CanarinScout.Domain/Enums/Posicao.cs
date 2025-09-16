using System.ComponentModel;

namespace CanarinScout.Domain.Enums
{
    public enum Posicao
    {
        [Description("Goleiro")]
        GK,
        [Description("Zagueiro")]
        DF,
        [Description("Lateral Esquerdo")]
        LB,
        [Description("Lateral Direito")]
        RB,
        [Description("Meio-campo")]
        MF,
        [Description("Atacante")]
        FW
    }
}

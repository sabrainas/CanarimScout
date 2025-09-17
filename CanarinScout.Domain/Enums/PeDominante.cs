using System.ComponentModel;

namespace CanarinScout.Domain.Enums
{
    public enum PeDominante
    {
        [Description("Direito")]
        Left,
        [Description("Esquerdo")]
        Right,
        [Description("Ambidestro")]
        Both
    }
}

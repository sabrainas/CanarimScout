using CanarinScout.Domain.Enums;

namespace CanarinScout.Domain.Extensions
{
    public static class PosicaoExtensions
    {
        public static Posicao Map(string valorBanco)
        {
            if (string.IsNullOrWhiteSpace(valorBanco))
                return Posicao.Desconhecido;

            valorBanco = valorBanco.ToUpper();

            if (valorBanco.Contains("GK"))
                return Posicao.GK;

            if (valorBanco.Contains("DF"))
                return Posicao.DF;

            if (valorBanco.Contains("LB"))
                return Posicao.LB;

            if (valorBanco.Contains("RB"))
                return Posicao.RB;

            if (valorBanco.Contains("MF"))
                return Posicao.MF;

            if (valorBanco.Contains("FW"))
                return Posicao.FW;

            return Posicao.Desconhecido;
        }
    }
}

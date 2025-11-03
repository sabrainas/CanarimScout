using CanarinScout.Domain.Enums;
using System.ComponentModel;
using System.Reflection;

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

            if (valorBanco.Contains("MF"))
                return Posicao.MF;

            if (valorBanco.Contains("FW"))
                return Posicao.FW;

            return Posicao.Desconhecido;
        }

        public static string GetDescription(this Posicao posicao)
        {
            var field = posicao.GetType().GetField(posicao.ToString());
            var attribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? posicao.ToString();
        }

        public static string? ToSigla(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            var normalized = input.Trim().ToUpperInvariant();

            if (normalized == "GK" || normalized == "DF" ||
                normalized == "MF" || normalized == "FW")
                return normalized;

            var lowerInput = input.Trim().ToLowerInvariant();

            if (lowerInput.Contains("gol"))
                return "GK";

            if (lowerInput.Contains("def") || lowerInput.Contains("zag"))
                return "DF";

            if (lowerInput.Contains("meio") || lowerInput.Contains("meia"))
                return "MF";

            if (lowerInput.Contains("ata"))
                return "FW";

            foreach (Posicao posicao in Enum.GetValues(typeof(Posicao)))
            {
                if (posicao == Posicao.Desconhecido)
                    continue;

                var description = posicao.GetDescription().ToLowerInvariant();

                if (description == lowerInput)
                    return posicao.ToString();
            }

            return null;
        }

        public static string ToSigla(this Posicao posicao)
        {
            return posicao switch
            {
                Posicao.GK => "GK",
                Posicao.DF => "DF",
                Posicao.MF => "MF",
                Posicao.FW => "FW",
                _ => "Desconhecido"
            };
        }
    }
}
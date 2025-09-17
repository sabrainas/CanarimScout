using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using CanarinScout.Domain.Enums;
using CanarinScout.Domain.Extensions;
using CanarinScout.Infrastructure.Interface;

namespace CanarinScout.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<List<JogadorDto>> SearchPlayersAsync(int skip, int take)
        {
            var players = await _playerRepository.GetAllPlayersAsync(skip, take);
            if (players == null || !players.Any()) return new List<JogadorDto>();

            return players.Select(p => new JogadorDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Posicao = PosicaoExtensions.Map(p.Posicao).GetDescription(),
                TimeAtual = p.TimeAtual,
                Foto = p.Foto,
                Idade = GetAge(p.DtNascimento)
            }).ToList();
        }

        public async Task<JogadorDetailDto> GetPlayerByIdAsync(int id)
        {
            var player = await _playerRepository.GetPlayerByIdAsync(id);
            if (player == null) return null;

            var posicao = PosicaoExtensions.Map(player.Posicao);
            var peDominante = ParseFoot(player.PeDominante);

            return new JogadorDetailDto
            {
                Id = player.Id,
                Nome = player.Nome,
                Posicao = posicao.GetDescription(),
                Idade = GetAge(player.DtNascimento),
                Peso = TryParseInt(player.Peso),
                Altura = TryParseInt(player.Altura),
                TimeAtual = player.TimeAtual,
                Foto = player.Foto,
                Selecao = player.Selecao,
                PeDominante = peDominante?.GetDescription() ?? "Desconhecido"
            };
        }

        private static int? TryParseInt(string? value)
            => int.TryParse(value, out var number) ? number : null;

        private static PeDominante? ParseFoot(string? sigla)
            => !string.IsNullOrEmpty(sigla) && Enum.TryParse<PeDominante>(sigla, out var pe) ? pe : null;

        private static int? GetAge(string? birthDateString)
            => DateTime.TryParse(birthDateString, out var birthDate) ? CalculateAge(birthDate) : null;

        private static int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}

using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using CanarinScout.Domain.Enums;
using CanarinScout.Infrastructure.Interface;

namespace CanarinScout.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        public PlayerService(
            IPlayerRepository playerRepository) 
        {
            _playerRepository = playerRepository;
        }

        public async Task<List<JogadorDto>> SearchPlayersAsync()
        {
            var players = await _playerRepository.GetAllPlayersAsync();
            var result = players.Select(p =>
            {
                var posicao = ParsePosition(p.Posicao);
                return new JogadorDto
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Posicao = posicao != null ? posicao.Value.GetDescription() : "Desconhecido",
                    TimeAtual = p.TimeAtual,
                    Foto = p.Foto,
                    Idade = GetAge(p.DtNascimento)
                };
            }).ToList();

            return result;
        }

        public async Task<JogadorDetailDto> GetPlayerByIdAsync(int id)
        {
            var player = await _playerRepository.GetPlayerByIdAsync(id);

            if (player == null)
                return null;

            var posicao = ParsePosition(player.Posicao);
            var peDominante = ParseFoot(player.PeDominante);

            var playerDto = new JogadorDetailDto
            {
                Id = player.Id,
                Nome = player.Nome,
                Posicao = posicao != null ? posicao.Value.GetDescription() : "Desconhecido",
                Idade = GetAge(player.DtNascimento),
                Peso = player.Peso,
                Altura = player.Altura,
                TimeAtual = player.TimeAtual,
                Foto = player.Foto,
                Selecao = player.Selecao,
                PeDominante = peDominante != null ? peDominante.Value.GetDescription() : "Desconhecido"
            };

            return playerDto;
        }

        private static PeDominante? ParseFoot(string? sigla)
        {
            if (!string.IsNullOrEmpty(sigla) && Enum.TryParse<PeDominante>(sigla, out var peDominante))
                return peDominante;
            return null;
        }

        private static Posicao? ParsePosition(string? sigla)
        {
            if (!string.IsNullOrEmpty(sigla) && Enum.TryParse<Posicao>(sigla, out var posicao))
                return posicao;
            return null;
        }

        private static int? GetAge(string? birthDateString)
        {
            if (string.IsNullOrEmpty(birthDateString) || !DateTime.TryParse(birthDateString, out var birthDate))
                return null;
            return CalculateAge(birthDate);
        }

        private static int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}

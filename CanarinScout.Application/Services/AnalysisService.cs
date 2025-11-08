using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Analysis;
using CanarinScout.Application.Interfaces;
using CanarinScout.Domain.Common;
using CanarinScout.Domain.Entities.Analysis;
using CanarinScout.Domain.Entities.Media;
using CanarinScout.Domain.Enums;
using CanarinScout.Domain.Extensions;
using CanarinScout.Infrastructure.Interface;

namespace CanarinScout.Application.Services
{
    public class AnalysisService : IAnalysisService
    {
        private readonly IAnalysisRepository _analysisRepository;
        private readonly IMapper _mapper;

        public AnalysisService(IAnalysisRepository analysisRepository, IMapper mapper)
        {
            _analysisRepository = analysisRepository;
            _mapper = mapper;
        }

        public async Task<PaginatedResult<JogadorDto>> GetPlayersWithFeaturesAsync(
            string? posicao,
            int skip,
            int take)
        {

            var result = await _analysisRepository.GetPlayersWithFeaturesAsync(
                posicao, skip, take);

            var dtos = result.Items.Select(MapToJogadorDto).ToList();

            return new PaginatedResult<JogadorDto>
            {
                Items = dtos,
                TotalCount = result.TotalCount,
                Page = result.Page,
                PageSize = result.PageSize
            };
        }

        public async Task<PlayerFeaturesDto?> GetPlayerCompleteByIdAsync(string playerId)
        {
            var playerFeatures = await _analysisRepository.GetPlayerFeaturesByPlayerIdAsync(playerId);

            if (playerFeatures == null)
                return null;

            var dto = MapToDto(playerFeatures);

            var posicaoEnum = PosicaoExtensions.Map(playerFeatures.Posicao);

            if(posicaoEnum == Posicao.GK)
            {
                var goleiroMedia = await _analysisRepository.GetGoleiroMediaByPlayerIdAsync(playerId);
                if (goleiroMedia != null)
                {
                    MapGoleiroMediaToDto(dto, goleiroMedia);
                }
            }

            return dto;
        }

        public async Task<List<PlayerFeaturesDto>> SearchPlayersByNameAsync(string query, int limit)
        {
            var players = await _analysisRepository.SearchPlayersByNameAsync(query, limit);

            return players.Select(MapToDto).ToList();
        }

        public async Task<object?> GetPlayerAnalysisByPosition(string playerId)
        {
            var playerFeatures = await _analysisRepository.GetPlayerFeaturesByPlayerIdAsync(playerId);

            if (playerFeatures == null || string.IsNullOrWhiteSpace(playerFeatures.Posicao))
                return null;

            var posicaoEnum = PosicaoExtensions.Map(playerFeatures.Posicao);

            return posicaoEnum switch
            {
                Posicao.FW => await GetAttackerAnalysisAsync(playerId),
                Posicao.MF => await GetMidfielderAnalysisAsync(playerId),
                Posicao.DF => await GetDefenseAnalysisAsync(playerId),
                Posicao.GK => await GetGoalkeeperAnalysisAsync(playerId),
                _ => null
            };
        }

        private async Task<AttackerAnalysisDto?> GetAttackerAnalysisAsync(string playerId)
        {
            var analysis = await _analysisRepository.GetAttackerAnalysisAsync(playerId);

            if (analysis == null)
                return null;

            var dto = _mapper.Map<AttackerAnalysisDto>(analysis);
            dto.PeDominante = ConvertPeDominante(analysis.PeDominante);
            dto.Altura = TryParseInt(analysis.Jogador.Altura);
            dto.Peso = TryParseInt(analysis.Jogador.Peso);

            return dto;
        }

        private async Task<MidfielderAnalysisDto?> GetMidfielderAnalysisAsync(string playerId)
        {
            var analysis = await _analysisRepository.GetMidfielderAnalysisAsync(playerId);

            if (analysis == null)
                return null;

            var dto = _mapper.Map<MidfielderAnalysisDto>(analysis);
            dto.PeDominante = ConvertPeDominante(analysis.PeDominante);
            dto.Altura = TryParseInt(analysis.Jogador.Altura);
            dto.Peso = TryParseInt(analysis.Jogador.Peso);

            return dto;
        }

        private async Task<DefenseAnalysisDto?> GetDefenseAnalysisAsync(string playerId)
        {
            var analysis = await _analysisRepository.GetDefenseAnalysisAsync(playerId);

            if (analysis == null)
                return null;

            var dto = _mapper.Map<DefenseAnalysisDto>(analysis);
            dto.PeDominante = ConvertPeDominante(analysis.PeDominante);
            dto.Altura = TryParseInt(analysis.Jogador.Altura);
            dto.Peso = TryParseInt(analysis.Jogador.Peso);

            return dto;
        }

        private async Task<GoalkeeperAnalysisDto?> GetGoalkeeperAnalysisAsync(string playerId)
        {
            var analysis = await _analysisRepository.GetGoalkeeperAnalysisAsync(playerId);

            if (analysis == null)
                return null;

            var dto = _mapper.Map<GoalkeeperAnalysisDto>(analysis);

            return dto;
        }

        private JogadorDto MapToJogadorDto(PlayerFeatures playerFeatures)
        {
            return new JogadorDto
            {
                PlayerId = playerFeatures.PlayerId,
                Nome = playerFeatures.Nome,
                Posicao = ConvertPosicao(playerFeatures.Posicao),
                TimeAtual = playerFeatures.Clube,
                Idade = GetAge(playerFeatures.DtNascimento),
                Foto = playerFeatures.Jogador?.Foto
            };
        }
        
        private PlayerFeaturesDto MapToDto(PlayerFeatures playerFeatures)
        {
            var dto = _mapper.Map<PlayerFeaturesDto>(playerFeatures);

            dto.Jogador.Posicao = ConvertPosicao(playerFeatures.Posicao);
            dto.Jogador.PeDominante = ConvertPeDominante(playerFeatures.PeDominante);
            dto.Jogador.Idade = GetAge(playerFeatures.DtNascimento);
            dto.Jogador.Altura = TryParseInt(playerFeatures.Altura);
            dto.Jogador.Peso = TryParseInt(playerFeatures.Peso);
            dto.Jogador.Foto = playerFeatures.Jogador?.Foto;

            return dto;
        }

        private void MapGoleiroMediaToDto(PlayerFeaturesDto dto, GoleiroMedia goleiroMedia)
        {
            dto.MinutosJogados = goleiroMedia.MinutosJogados;

            dto.ChutesNoGol = goleiroMedia.ChutesNoGol;
            dto.GolSofridos = goleiroMedia.GolSofridos;
            dto.Defesas = goleiroMedia.Defesas;
            dto.PerDefesas = goleiroMedia.PerDefesas;
            dto.PartidaSemGol = goleiroMedia.PartidaSemGol;
            dto.GolsEsperados = goleiroMedia.GolsEsperados;

            dto.PenaltisCausados = goleiroMedia.PenaltiCausados;
            dto.PenaltiSofrido = goleiroMedia.PenaltiSofrido;
            dto.PenaltisDefendidos = goleiroMedia.PenaltiDefendidos;
            dto.PenaltiErrado = goleiroMedia.PenaltiErrado;

            dto.PassesConcluidos = goleiroMedia.PassesConcluidos;
            dto.TentativasPasses = goleiroMedia.TentativasPasses;
            dto.PerPassesConcluidos = goleiroMedia.PerPassesConcluidos;
            dto.QtdTirosDeMeta = goleiroMedia.QtdTirosDeMeta;
            dto.LancamentoTotal = goleiroMedia.LancamentoTotal;
            dto.PerLancamentosCompletos = goleiroMedia.PerLancamentosCompletos;
            dto.DistMediaLancamentos = goleiroMedia.DistMediaLancamentos;
            dto.TentativasLancamentos = goleiroMedia.TentativasLancamentos;
            dto.DistMediaTiroDeMeta = goleiroMedia.DistMediaTiroDeMeta;

            dto.CruzamentosEnfrentados = goleiroMedia.CruzamentosEnfrentados;
            dto.CruzamentoBloqueado = goleiroMedia.CruzamentoBloqueado;
            dto.PerCruzamentoBloqueado = goleiroMedia.PerCruzamentoBloqueado;
            dto.AcoesForaDaPequenaArea = goleiroMedia.AcoesForaDaPequenaArea;
            dto.DistMedia = goleiroMedia.DistMedia;
        }

        private static string? ConvertPosicao(string? posicao)
        {
            if (string.IsNullOrWhiteSpace(posicao))
                return "Desconhecido";

            var posicaoEnum = PosicaoExtensions.Map(posicao);
            return posicaoEnum.GetDescription();
        }

        private static string? ConvertPeDominante(string? peDominante)
        {
            var pe = ParseFoot(peDominante);
            return pe?.GetDescription() ?? "Desconhecido";
        }

        private static PeDominante? ParseFoot(string? sigla)
        {
            if (string.IsNullOrEmpty(sigla))
                return null;

            return Enum.TryParse<PeDominante>(sigla, true, out var pe) ? pe : null;
        }

        private static int? TryParseInt(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            return int.TryParse(value, out var number) ? number : null;
        }

        private static int? GetAge(string? birthDateString)
        {
            if (string.IsNullOrWhiteSpace(birthDateString))
                return null;

            return DateTime.TryParse(birthDateString, out var birthDate)
                ? CalculateAge(birthDate)
                : null;
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
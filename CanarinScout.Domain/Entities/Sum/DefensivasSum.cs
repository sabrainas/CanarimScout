namespace CanarinScout.Domain.Entities.Sum
{
    public class DefensivasSum
    {
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;

        public decimal? DesarmesConcluidos { get; private set; }
        public decimal? DesarmesDefensivos { get; private set; }
        public decimal? DesarmesCentrais { get; private set; }
        public decimal? DesarmesAtaque { get; private set; }
        public decimal? TentativaDesarmes { get; private set; }
        public decimal? PerDesDriblador { get; private set; }
        public decimal? DesDriblador { get; private set; }
        public decimal? Bloqueios { get; private set; }
        public decimal? ChutesBloqueados { get; private set; }
        public decimal? PassesBloqueados { get; private set; }
        public decimal? Interceptacoes { get; private set; }
        public decimal? DesarmesInterceptacoes { get; private set; }
        public decimal? Defesas { get; private set; }
        public decimal? Erros { get; private set; }

        public DefensivasSum() { }

        public DefensivasSum(string playerId, Jogador jogador, decimal? desarmesConcluidos, 
            decimal? desarmesDefensivos, decimal? desarmesCentrais, decimal? desarmesAtaque, 
            decimal? tentativaDesarmes, decimal? perDesDriblador, decimal? desDriblador, 
            decimal? bloqueios, decimal? chutesBloqueados, decimal? passesBloqueados, 
            decimal? interceptacoes, decimal? desarmesInterceptacoes, decimal? defesas, decimal? erros)
        {
            PlayerId = playerId;
            Jogador = jogador;
            DesarmesConcluidos = desarmesConcluidos;
            DesarmesDefensivos = desarmesDefensivos;
            DesarmesCentrais = desarmesCentrais;
            DesarmesAtaque = desarmesAtaque;
            TentativaDesarmes = tentativaDesarmes;
            PerDesDriblador = perDesDriblador;
            DesDriblador = desDriblador;
            Bloqueios = bloqueios;
            ChutesBloqueados = chutesBloqueados;
            PassesBloqueados = passesBloqueados;
            Interceptacoes = interceptacoes;
            DesarmesInterceptacoes = desarmesInterceptacoes;
            Defesas = defesas;
            Erros = erros;
        }
    }
}

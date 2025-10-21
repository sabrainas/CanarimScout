namespace CanarinScout.Domain.Entities.Sum
{
    public class PossesSum
    {
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;
        
        public decimal? Contatos { get; private set; }
        public decimal? ContatosDefensivosPen { get; private set; }
        public decimal? ContatosTercoDef { get; private set; }
        public decimal? ContatosTercoCentral { get; private set; }
        public decimal? ContatosTercoAtaque { get; private set; }
        public decimal? ContatosAtaquePen { get; private set; }
        public decimal? ContatoBolaJogo { get; private set; }
        public decimal? TentativasDribles { get; private set; }
        public decimal? DriblesCompletos { get; private set; }
        public decimal? PerDriblesCompletos { get; private set; }
        public decimal? DriblesInterrompidos { get; private set; }
        public decimal? PerDriblesInterrompidos { get; private set; }
        public decimal? Conducoes { get; private set; }
        public decimal? DistTotal { get; private set; }
        public decimal? DistProgressivas { get; private set; }
        public decimal? CarregadaProgressiva { get; private set; }
        public decimal? CarregadaTercoFinal { get; private set; }
        public decimal? CarregadaAreaPenalti { get; private set; }
        public decimal? PerdaDominio { get; private set; }
        public decimal? Desarmado { get; private set; }
        public decimal? PassesRecebidos { get; private set; }
        public decimal? PassesProgressivosRecebidos { get; private set; }

        public PossesSum() { }

        public PossesSum(string playerId, Jogador jogador, decimal? contatos, decimal? contatosDefensivosPen,
            decimal? contatosTercoDef, decimal? contatosTercoCentral, decimal? contatosTercoAtaque, decimal? contatosAtaquePen,
            decimal? contatoBolaJogo, decimal? tentativasDribles, decimal? driblesCompletos, decimal? perDriblesCompletos,
            decimal? driblesInterrompidos, decimal? perDriblesInterrompidos, decimal? conducoes, decimal? distTotal,
            decimal? distProgressivas, decimal? carregadaProgressiva, decimal? carregadaTercoFinal, decimal? carregadaAreaPenalti,
            decimal? perdaDominio, decimal? desarmado, decimal? passesRecebidos, decimal? passesProgressivosRecebidos)
        {
            PlayerId = playerId;
            Jogador = jogador;
            Contatos = contatos;
            ContatosDefensivosPen = contatosDefensivosPen;
            ContatosTercoDef = contatosTercoDef;
            ContatosTercoCentral = contatosTercoCentral;
            ContatosTercoAtaque = contatosTercoAtaque;
            ContatosAtaquePen = contatosAtaquePen;
            ContatoBolaJogo = contatoBolaJogo;
            TentativasDribles = tentativasDribles;
            DriblesCompletos = driblesCompletos;
            PerDriblesCompletos = perDriblesCompletos;
            DriblesInterrompidos = driblesInterrompidos;
            PerDriblesInterrompidos = perDriblesInterrompidos;
            Conducoes = conducoes;
            DistTotal = distTotal;
            DistProgressivas = distProgressivas;
            CarregadaProgressiva = carregadaProgressiva;
            CarregadaTercoFinal = carregadaTercoFinal;
            CarregadaAreaPenalti = carregadaAreaPenalti;
            PerdaDominio = perdaDominio;
            Desarmado = desarmado;
            PassesRecebidos = passesRecebidos;
            PassesProgressivosRecebidos = passesProgressivosRecebidos;
        }
    }
}

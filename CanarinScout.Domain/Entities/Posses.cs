namespace CanarinScout.Domain.Entities
{
    public class Posses
    {
        public int Id { get; private set; }
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;
        public string? Contatos { get; private set; }               // touches
        public string? ContatosDefensivosPen { get; private set; }  // def_pen
        public string? ContatosTercoDef { get; private set; }       // def_3rd
        public string? ContatosTercoCentral { get; private set; }   // mid_3rd
        public string? ContatosTercoAtaque { get; private set; }    // att_3rd
        public string? ContatosAtaquePen { get; private set; }      // att_pen
        public string? ContatoBolaJogo { get; private set; }        // live
        public string? TentativasDribles { get; private set; }      // att
        public string? DriblesCompletos { get; private set; }       // succ
        public string? PerDriblesCompletos { get; private set; }  // succ %
        public string? DriblesInterrompidos { get; private set; }   // tkld
        public string? PerDriblesInterrompidos { get; private set; } // tkld %
        public string? Conducoes { get; private set; }              // carries
        public string? DistTotal { get; private set; }              // totdist
        public string? DistProgressivas { get; private set; }       // prgdist
        public string? CarregadaProgressiva { get; private set; }   // prgc
        public string? CarregadaTercoFinal { get; private set; }    // prgr
        public string? CarregadaAreaPenalti { get; private set; }   // cpa
        public string? PerdaDominio { get; private set; }           // mis
        public string? Desarmado { get; private set; }              // tkld1
        public string? PassesRecebidos { get; private set; }        // rec
        public string? PassesProgressivosRecebidos { get; private set; } // prgp?

        public Posses() { }

        public Posses(string? contatos, string? contatosDefensivosPen, string? contatosTercoDef, string? contatosTercoCentral, string? contatosTercoAtaque, string? contatosAtaquePen, string? contatoBolaJogo, string? tentativasDribles, string? driblesCompletos, string? perDriblesCompletos, string? driblesInterrompidos, string? perDriblesInterrompidos, string? conducoes, string? distTotal, string? distProgressivas, string? carregadaProgressiva, string? carregadaTercoFinal, string? carregadaAreaPenalti, string? perdaDominio, string? desarmado, string? passesRecebidos, string? passesProgressivosRecebidos)
        {
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

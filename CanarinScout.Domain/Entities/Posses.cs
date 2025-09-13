namespace CanarinScout.Domain.Entities
{
    public class Posses
    {
        public int Id { get; set; }
        public string? Contatos { get; set; }               // touches
        public string? ContatosDefensivosPen { get; set; }  // def_pen
        public string? ContatosTercoDef { get; set; }       // def_3rd
        public string? ContatosTercoCentral { get; set; }   // mid_3rd
        public string? ContatosTercoAtaque { get; set; }    // att_3rd
        public string? ContatosAtaquePen { get; set; }      // att_pen
        public string? ContatoBolaJogo { get; set; }        // live
        public string? TentativasDribles { get; set; }      // att
        public string? DriblesCompletos { get; set; }       // succ
        public string? PerDriblesCompletos { get; set; }  // succ %
        public string? DriblesInterrompidos { get; set; }   // tkld
        public string? PerDriblesInterrompidos { get; set; } // tkld %
        public string? Conducoes { get; set; }              // carries
        public string? DistTotal { get; set; }              // totdist
        public string? DistProgressivas { get; set; }       // prgdist
        public string? CarregadaProgressiva { get; set; }   // prgc
        public string? CarregadaTercoFinal { get; set; }    // prgr
        public string? CarregadaAreaPenalti { get; set; }   // cpa
        public string? PerdaDominio { get; set; }           // mis
        public string? Desarmado { get; set; }              // tkld1
        public string? PassesRecebidos { get; set; }        // rec
        public string? PassesProgressivosRecebidos { get; set; } // prgp?

        private Posses() { }

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

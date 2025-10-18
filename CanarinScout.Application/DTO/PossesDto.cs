namespace CanarinScout.Application.DTO
{
    public class PossesDto
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
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
    }
}

namespace CanarinScout.Domain.Entities
{
    public class Defensivas
    {
        public int Id { get; set; }
        public Jogador Jogador { get; set; }
        public string PlayerId { get; set; }
        public string? Competicao { get; set; }        // Comp
        public string? DesarmesConcluidos { get; set; } // Tkl1
        public string? PassesBloqueados { get; set; }  // Blocks
        public string? Interceptacoes { get; set; }    // Int
        public string? TentativaDesarmes { get; set; } // Att
        public string? DesDriblador { get; set; }      // Lost
        public string? Bloqueios { get; set; }         // Blocks
        public string? ChutesBloqueados { get; set; }  // Sh
        public string? Defesas { get; set; }           // Pass
        public string? Erros { get; set; }             // Err
        public string? PerDesDriblador { get; set; }
        public string? DesarmesDefensivos { get; set; }
        public string? DesarmesAtaque { get; set; }
        public string? DesarmesCentrais { get; set; }

        private Defensivas() { }

        public Defensivas(int id, string? competicao, string? desarmesConcluidos, string? passesBloqueados, string? interceptacoes, string? tentativaDesarmes, string? desDriblador, string? bloqueios, string? chutesBloqueados, string? defesas, string? erros, string? perDesDriblador, string? desarmesDefensivos, string? desarmesAtaque, string? desarmesCentrais)
        {
            Id = id;
            Competicao = competicao;
            DesarmesConcluidos = desarmesConcluidos;
            PassesBloqueados = passesBloqueados;
            Interceptacoes = interceptacoes;
            TentativaDesarmes = tentativaDesarmes;
            DesDriblador = desDriblador;
            Bloqueios = bloqueios;
            ChutesBloqueados = chutesBloqueados;
            Defesas = defesas;
            Erros = erros;
            PerDesDriblador = perDesDriblador;
            DesarmesDefensivos = desarmesDefensivos;
            DesarmesAtaque = desarmesAtaque;
            DesarmesCentrais = desarmesCentrais;
        }
    }
}

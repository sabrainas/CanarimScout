namespace CanarinScout.Domain.Entities
{
    public class Defensivas
    {
        public int Id { get; set; }
        public string Desarmes { get; set; }
        public string Cortes { get; set; }
        public string Competicao { get; set; }
        public string DesarmesMidDefensivo { get; set; }
        public string Desarmes3rdAtaque { get; set; }
        public string Desarmes3rdDefensivos { get; set; }
        public string DriblesDesarmados { get; set; }
        public string DesarmesConcluidos { get; set; }
        public string PassesBloqueados { get; set; }
        public string Interceptacoes { get; set; }
        public string TentativaDesarmes { get; set; }
        public string DesarmesDefensivos { get; set; }
        public string DesarmesCentrais { get; set; }
        public string DesarmesAtaque { get; set; }
        public string TentDesDriblador { get; set; }
        public string DesDriblador { get; set; }
        public float PerDesDriblador { get; set; }
        public string Bloqueios { get; set; }
        public string ChutesBloqueados { get; set; }
        public string? Defesas { get; set; }
        public string Erros { get;  set; }

        private Defensivas() { }

        public Defensivas(string desarmes, string tentativaDesarmes, string desarmesDefensivos, string desarmesCentrais, string desarmesAtaque, string tentDesDriblador, string desDriblador, float perDesDriblador, string bloqueios, string chutesBloqueados, string passesBloqueados, string interceptacoes, string? defesas, string erros)
        {
            Desarmes = desarmes;
            TentativaDesarmes = tentativaDesarmes;
            DesarmesDefensivos = desarmesDefensivos;
            DesarmesCentrais = desarmesCentrais;
            DesarmesAtaque = desarmesAtaque;
            TentDesDriblador = tentDesDriblador;
            DesDriblador = desDriblador;
            PerDesDriblador = perDesDriblador;
            Bloqueios = bloqueios;
            ChutesBloqueados = chutesBloqueados;
            PassesBloqueados = passesBloqueados;
            Interceptacoes = interceptacoes;
            Defesas = defesas;
            Erros = erros;
        }
    }
}

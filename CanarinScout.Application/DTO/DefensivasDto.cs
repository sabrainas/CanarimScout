namespace CanarinScout.Application.DTO
{
    public class DefensivasDto
    {
        public int Id { get; set; }
        public int Desarmes { get; set; }
        public int TentativaDesarmes { get; set; }
        public int DesarmesDefensivos { get; set; }
        public int DesarmesCentrais { get; set; }
        public int DesarmesAtaque { get; set; }
        public int TentDesDriblador { get; set; }
        public int DesDriblador { get; set; }
        public float PerDesDriblador { get; set; }
        public int Bloqueios { get; set; }
        public int ChutesBloqueados { get; set; }
        public int PassesBloqueados { get; set; }
        public int Interceptacoes { get; set; }
        public int? Defesas { get; set; }
        public int Erros { get; set; }
    }
}

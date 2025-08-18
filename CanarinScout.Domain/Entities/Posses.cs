namespace CanarinScout.Domain.Entities
{
    public class Posses
    {
        public int Id { get; private set; }
        public int Contatos { get; private set; }
        public int ContatosDefensivosPen { get; private set; }
        public int ContatosTercoDef { get; private set; }
        public int ContatosTercoCentral { get; private set; }
        public int ContatosTercoAtaque { get; private set; }
        public int ContatosAtaquePen { get; private set; }
        public int ContatoBolaParada { get; private set; }
        public int ContatoBolaJogo { get; private set; }
        public int TentativasDribles { get; private set; }
        public int DriblesCompletos { get; private set; }
        public float PerDriblesCompletos { get; private set; }
        public int DriblesInterrompidos { get; private set; }
        public float PerDriblesInterrompidos { get; private set; }
        public int Conducoes { get; private set; }
        public int DistTotal { get; private set; }
        public int DistProgressivas { get; private set; }
        public int CarregadaProgressiva { get; private set; }
        public int CarregadaTercoFinal { get; private set; }
        public int CarregadaAreaPenalti { get; private set; }
        public int PerdaDominio { get; private set; }
        public int Desarmado { get; private set; }
        public int PassesRecebidos { get; private set; }
        public int PassesProgressivosRecebidos { get; private set; }
        public int DispAereasGanhas { get; private set; }
        public int DispAereasPerdidas { get; private set; }
        public int PerDispAereasGanhas { get; private set; }

        private Posses() { }

        public Posses(int contatos, int contatosDefensivosPen, int contatosTercoDef, int contatosTercoCentral, int contatosTercoAtaque, int contatosAtaquePen, int contatoBolaParada, int contatoBolaJogo, int tentativasDribles, int driblesCompletos, float perDriblesCompletos, int driblesInterrompidos, float perDriblesInterrompidos, int conducoes, int distTotal, int distProgressivas, int carregadaProgressiva, int carregadaTercoFinal, int carregadaAreaPenalti, int perdaDominio, int desarmado, int passesRecebidos, int passesProgressivosRecebidos, int dispAereasGanhas, int dispAereasPerdidas, int perDispAereasGanhas)
        {
            Contatos = contatos;
            ContatosDefensivosPen = contatosDefensivosPen;
            ContatosTercoDef = contatosTercoDef;
            ContatosTercoCentral = contatosTercoCentral;
            ContatosTercoAtaque = contatosTercoAtaque;
            ContatosAtaquePen = contatosAtaquePen;
            ContatoBolaParada = contatoBolaParada;
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
            DispAereasGanhas = dispAereasGanhas;
            DispAereasPerdidas = dispAereasPerdidas;
            PerDispAereasGanhas = perDispAereasGanhas;
        }
    }
}

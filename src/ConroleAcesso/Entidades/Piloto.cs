using System.Collections.Generic;

namespace ConroleAcesso.Entidades
{
    public class Piloto
    {
        public int IdPiloto { get; set; }
        public string Nome { get; set; }
        public string AnoNascimento { get; set; }
        public int IdPlaneta { get; set; }

        //Relacionamentos
        public Planeta Planeta { get; set; }
        public List<Nave> Naves { get; set; }
    }
}


//--*****Projeto replicado do Bootcamp Everis New talents 3 MADS1974 * ****--//
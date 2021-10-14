using System.Collections.Generic;

namespace ConroleAcesso.ViewModels
{
    public class ResultadoApi<ViewModel>
    {
        public string Next { get; set; }
        public IReadOnlyList<ViewModel> Results { get; set; }
    }
}


//--*****Projeto replicado do Bootcamp Everis New talents 3 MADS1974 * ****--//
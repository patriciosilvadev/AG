//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AG
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public usuario()
        {
            this.usuario_has_projeto = new HashSet<usuario_has_projeto>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string emaill { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string perfil { get; set; }
        public string img { get; set; }
        public string cargo { get; set; }
        public Nullable<int> projetoID { get; set; }
    
        public virtual ICollection<usuario_has_projeto> usuario_has_projeto { get; set; }
        public virtual projeto projeto { get; set; }
    }
}

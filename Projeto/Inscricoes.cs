//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inscricoes
    {
        public bool Confirmada { get; set; }
        public int IdFilho { get; set; }
        public int NrEvento { get; set; }
    
        public virtual Filhos Filhos { get; set; }
        public virtual Eventos Eventos { get; set; }

        public override string ToString()
        {
            return Filhos.Nome;
        }


    }
}

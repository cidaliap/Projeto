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
    
    public partial class Compras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compras()
        {
            this.DetalheCompras = new HashSet<DetalheCompras>();
        }
    
        public int NrCompra { get; set; }
        public int IdCliente { get; set; }
        public System.DateTime Data { get; set; }
        public string UtilizouCartao { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalheCompras> DetalheCompras { get; set; }

        public const double iva = 0.23;

        public override string ToString()
        {
            return Data + "   Utilizou Cart�o: " + UtilizouCartao;

       }

        public double getTotalCompra()
        {
            double total = 0;
            foreach (DetalheCompras dc in DetalheCompras)
            {
                total += (dc.Quantidade * dc.Produtos.Preco) + (dc.Quantidade * dc.Produtos.Preco * iva);
            }
            return total;
        }

    }
}
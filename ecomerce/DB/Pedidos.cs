//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecomerce.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedidos
    {
        public int ID { get; set; }
        public Nullable<int> IDCliente { get; set; }
        public Nullable<int> IDListaPedido { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual ListaPedido ListaPedido { get; set; }
    }
}

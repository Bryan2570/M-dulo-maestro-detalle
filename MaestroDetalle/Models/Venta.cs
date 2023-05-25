﻿namespace MaestroDetalle.Models
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string NumeroDocumento { get; set; }
        public string RazonSocial { get; set; }
        public decimal Total { get; set; }

        public List<DetalleVenta> listDetalleVenta { get; set; }
    }
}

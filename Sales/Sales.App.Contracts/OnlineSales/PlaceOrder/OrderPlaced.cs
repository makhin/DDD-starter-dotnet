using System;

namespace MyCompany.Crm.Sales.OnlineSales.PlaceOrder
{
    public readonly struct OrderPlaced
    {
        public Guid OrderId { get; }
        public Guid ClientId { get; }
        public DateTime PlacedOn { get; }

        public OrderPlaced(Guid orderId, Guid clientId, DateTime placedOn)
        {
            OrderId = orderId;
            ClientId = clientId;
            PlacedOn = placedOn;
        }
    }
}
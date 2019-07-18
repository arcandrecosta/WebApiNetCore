using BaltaStore.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Order
    {

        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;

        public Order(Custumer custumer, string number)
        {
            Custumer = custumer;
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            _items = new List<OrderItem>();
            _deliveries = new List<Delivery>();
        }

        public Custumer Custumer { get; set; }
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public EOrderStatus Status { get; set; }
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        public void AddItem(OrderItem item)
        {
            //Valida Item
            //Adiciona Item no pedido
            _items.Add(item);
        }

        
        //Criar um pedid0 
        public void Place(){}

        //pagar um pedido
        public void Pay()
        {
            Status = EOrderStatus.Paid;
           
        }
        //Enviar um pedido

        public void Ship()
        {
            var deliveries = new List<Delivery>();
            deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
            var count = 1;

            foreach (var item in _items)
            {
                if(count == 5)
                {
                    count = 0;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
                }
                count++;

            }

            deliveries.ForEach(x => x.Ship());
            deliveries.ForEach(x => _deliveries.Add(x));
        }

        //Cancelar um pedido
        public void Cancel()
        {
            Status = EOrderStatus.Canceled;

            _deliveries.ToList().ForEach(x => x.Cancel());
        }
    }
}
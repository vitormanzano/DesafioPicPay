namespace DesafioPicPay.Models
{
    public class Transfer
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public Guid PayerId { get; set; }
        public User Payer { get; set; }
        public Guid PayeeId { get; set; }
        public User Payee { get; set; }

        protected Transfer() { }
    }
}

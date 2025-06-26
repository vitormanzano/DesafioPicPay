namespace DesafioPicPay.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public decimal AccountBalance { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        protected Wallet() { }
    }
}

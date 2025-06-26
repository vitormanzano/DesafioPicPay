using DesafioPicPay.Enums;

namespace DesafioPicPay.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string CompleteName { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public List<Transfer> Transfers { get; set; }

        protected User() { }

    }
}

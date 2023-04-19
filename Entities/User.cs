namespace AuthGuardExample.Entities
{
    public class User
    {
        public User() { }

        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
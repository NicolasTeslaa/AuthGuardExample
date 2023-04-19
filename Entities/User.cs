namespace AuthGuardExample.Entities
{
    public class User
    {
        public User() { }
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Senha { get; set; }
        public string ConfSenha { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
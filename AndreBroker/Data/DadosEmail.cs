namespace AndreBroker.Data
{
    public class DadosEmail
    {
        public string SMTP { get; set; } = "smtp.gmail.com";
        public int Port { get; set; } = 587;
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}

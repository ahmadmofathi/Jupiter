using System.Reflection.Emit;
using System.Security.Cryptography.Xml;

namespace Jupiter.DAL
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string WhatsApp { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public int JupiterCoins { get; set; }
        public int SalaryBasic { get; set; }
        public int Bonus { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;

        public User(string name, string email, string password, string whatsApp, string phoneNumber, string role, int jupiterCoins, int salaryBasic, int bonus, string address, string branch)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            WhatsApp = whatsApp ?? throw new ArgumentNullException(nameof(whatsApp));
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            Role = role ?? throw new ArgumentNullException(nameof(role));
            JupiterCoins = jupiterCoins;
            SalaryBasic = salaryBasic;
            Bonus = bonus;
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Branch = branch ?? throw new ArgumentNullException(nameof(branch));
        }
        public ICollection<Tasks> Tasks { get; set; } = new HashSet<Tasks>();
    }
}

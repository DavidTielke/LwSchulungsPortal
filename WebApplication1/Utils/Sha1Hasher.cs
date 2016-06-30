using System.Security.Cryptography;
using System.Text;
using WebApplication1.ViewModels;

namespace WebApplication1.Utils
{
    public class Sha1Hasher
    {
        public Sha1Hasher()
        {
        }

        public string ComputeHash(AccountRegisterViewModel viewModel)
        {
            var provider = new SHA1CryptoServiceProvider();
            var passwordBytes = Encoding.UTF8.GetBytes(viewModel.Participant.Password);
            var passwordHashedBytes = provider.ComputeHash(passwordBytes);
            var hashedPassword = Encoding.ASCII.GetString(passwordHashedBytes);
            return hashedPassword;
        }
    }
}
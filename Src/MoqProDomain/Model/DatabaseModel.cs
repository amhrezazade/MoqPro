using MoqProDomain.Entity;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace MoqProDomain.Model
{
    public class DatabaseModel
    {
        public List<Request> Requests { get; set; }
        public List<DataType> DataTypes { get; set; }

        public string Gethash()
        {
            var str = JsonConvert.SerializeObject(Requests) + JsonConvert.SerializeObject(DataTypes);
            return GetMd5Hash(str);
        }

        public static string GetMd5Hash(string input)
        {
            // handle null input gracefully
            input ??= string.Empty;

            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder(hashBytes.Length * 2);
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2")); // lowercase hex

                return sb.ToString();
            }
        }

    }
}

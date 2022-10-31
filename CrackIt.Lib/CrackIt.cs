using System.Security.Cryptography;
using System.Text;
 
namespace CrackIt.Lib
{
    public class CrackIt
    {
        /// <summary>
        /// Random pw gen
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GeneratePassword(int length)
        {
            const string valid = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        /// <summary>
        /// Generates all combinations of a given string
        /// </summary>
        /// <param name="validchars"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static IEnumerable<string> GeneratePermutations(string validchars, int length)
        {
            if (length == 1)
            {
                foreach (char c in validchars)
                {
                    yield return c.ToString();
                }
            }
            else
            {
                foreach (char c in validchars)
                {
                    foreach (string s in GeneratePermutations(validchars, length - 1))
                    {
                        yield return c + s;
                    }
                }
            }
        }
        
    }
}
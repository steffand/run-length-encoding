using System.Text;

namespace RunLengthEncodingApp
{
    public static class Encoder
    {
        public static string RunLengthEncode(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            StringBuilder result = new StringBuilder();
            int count = 1;
            char current = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == current)
                {
                    count++;
                }
                else
                {
                    result.Append(count);
                    result.Append(current);
                    current = input[i];
                    count = 1;
                }
            }

            result.Append(count);
            result.Append(current);

            return result.ToString();
        }
    }
}

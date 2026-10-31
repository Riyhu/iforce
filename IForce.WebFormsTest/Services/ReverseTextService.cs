namespace IForce.WebFormsTest.Services
{
    public class ReverseTextService
    {
        public string Reverse(string text)
        {
            var value = text ?? "";
            return Reverse(value, value.Length - 1);
        }

        private string Reverse(string text, int index)
        {
            if (index < 0)
            {
                return "";
            }

            return text[index] + Reverse(text, index - 1);
        }
    }
}

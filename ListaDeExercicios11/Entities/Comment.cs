using System.Runtime.InteropServices;

namespace ListaDeExercicios11.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment ()
        {

        }

        public Comment (string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}

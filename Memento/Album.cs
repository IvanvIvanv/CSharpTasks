using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Album
    {
        public Stack<Image> images = new();

        public override string ToString()
        {
            StringBuilder builder = new();

            for (int i = images.Count - 1; i >= 0; i--)
            {
                builder.AppendLine(images.ElementAt(i).content);
            }

            return builder.ToString();
        }
    }
}

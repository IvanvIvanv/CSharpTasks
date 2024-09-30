using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndGenerics
{
    public struct Book<T>(string? name, uint pageCount, string? author, T? id)
    {
        public string? name = name;
        public uint pageCount = pageCount;
        public string? author = author;
        public T? id = id;

        public override readonly string ToString()
        {
            return
                (id != null ? id.ToString() : "no id") + ", " +
                (name ?? "no name") + ", " +
                (author ?? "no author") + ", " +
                pageCount + " pages";
        }
    }
}

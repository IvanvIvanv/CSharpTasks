using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTask
{
    public class BrickStructure(string name)
    {
        public string name = name;

        private readonly List<string> bricks = [];

        public void AddBrick(string brick)
        {
            bricks.Add(brick);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append($"{name} consists of: ");

            foreach (var part in bricks)
            {
                sb.Append($"{part.ToString()}, ");
            }

            return sb.ToString();
        }
    }
}

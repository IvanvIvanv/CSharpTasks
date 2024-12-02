using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTask
{
    public class ColorfulBrickStructureBuilder(string name) : BrickStructureBuilder(name)
    {
        public void AddRedBrick()
        {
            brickStructure.AddBrick("Red brick");
        }

        public void AddGreenBrick()
        {
            brickStructure.AddBrick("Green brick");
        }

        public void AddBlueBrick()
        {
            brickStructure.AddBrick("Blue brick");
        }
    }
}

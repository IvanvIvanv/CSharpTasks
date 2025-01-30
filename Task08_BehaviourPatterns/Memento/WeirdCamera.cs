using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class WeirdCamera
    {
        public string content = "";

        public Image TakePhoto()
        {
            return new Image(content);
        }

        public void LoadPhoto(Image image)
        {
            content = image.content;
        }
    }
}

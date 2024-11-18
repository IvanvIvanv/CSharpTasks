using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeTask
{
    internal class MusicStation
    {
        public bool IsTurnedOn { get; set; }
        public string Music { get; set; } = "";

        public void Switch(bool newState)
        {
            IsTurnedOn = newState;
        }

        public void SetMusic(string newMusic)
        {
            Music = newMusic;
        }

        public override string ToString()
        {
            return $"IsTurnedOn: {IsTurnedOn}, Brightness: {Music}";
        }
    }
}

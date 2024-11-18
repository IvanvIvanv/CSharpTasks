using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeTask
{
    internal class TV
    {
        public bool IsTurnedOn { get; set; }
        public string Program { get; set; } = "";

        public void SwitchTV(bool newState)
        {
            IsTurnedOn = newState;
        }

        public void TurnOnProgram(string newProgram)
        {
            Program = newProgram;
        }

        public override string ToString()
        {
            return $"IsTurnedOn: {IsTurnedOn}, Program: {Program}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeTask
{
    internal class AirConditioner
    {
        public bool IsTurnedOn { get; set; }
        public float Temperaure { get; set; } = 23f;

        public void Switch(bool newState)
        {
            IsTurnedOn = newState;
        }

        public void SetTemperature(float newTemperature)
        {
            Temperaure = newTemperature;
        }

        public override string ToString()
        {
            return $"IsTurnedOn: {IsTurnedOn}, Temperature: {Temperaure}";
        }
    }
}

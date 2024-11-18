using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SmartHomeTask
{
    internal class Light
    {
        public bool IsTurnedOn { get; set; }
        public float Brightness { get; set; } = 0.5f;
        public Color Color { get; set; } = Color.White;

        public void SwitchLight(bool newState)
        {
            IsTurnedOn = newState;
        }

        public void ChangeBrightness(float newBrightness)
        {
            Brightness = newBrightness;
        }

        public void ChangeColor(Color newColor)
        {
            Color = newColor;
        }

        public override string ToString()
        {
            return $"IsTurnedOn: {IsTurnedOn}, Brightness: {Brightness}, Color: {Color}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeTask
{
    internal class SmartHome
    {
        private readonly Light light = new();
        private readonly TV tv = new();
        private readonly AirConditioner airConditioner = new();
        private readonly MusicStation musicStation = new();

        public enum Mode
        {
            Morning,
            Day,
            Evening,
            Night,
        }

        public void SetupHome(Mode mode)
        {
            switch(mode)
            {
                case Mode.Morning:
                    light.SwitchLight(false);
                    tv.SwitchTV(true);
                    tv.TurnOnProgram("Weather");
                    airConditioner.Switch(false);
                    musicStation.Switch(true);
                    musicStation.SetMusic("NewDayMusic");
                    break;

                case Mode.Day:
                    light.SwitchLight(false);
                    tv.SwitchTV(true);
                    tv.TurnOnProgram("FarmingTutorials");
                    airConditioner.Switch(true);
                    airConditioner.SetTemperature(20f);
                    musicStation.Switch(true);
                    musicStation.SetMusic("FarmingMusic");
                    break;

                case Mode.Evening:
                    light.SwitchLight(true);
                    light.ChangeBrightness(0.7f);
                    light.ChangeColor(System.Drawing.Color.LightYellow);
                    tv.SwitchTV(true);
                    tv.TurnOnProgram("Entertainment");
                    airConditioner.Switch(true);
                    airConditioner.SetTemperature(24f);
                    musicStation.Switch(true);
                    musicStation.SetMusic("CalmEvening");
                    break;

                case Mode.Night:
                    light.SwitchLight(true);
                    light.ChangeBrightness(0.2f);
                    light.ChangeColor(System.Drawing.Color.Yellow);
                    tv.SwitchTV(false);
                    airConditioner.Switch(true);
                    airConditioner.SetTemperature(26f);
                    musicStation.Switch(false);
                    break;
            }

            Console.WriteLine(light.ToString());
            Console.WriteLine(tv.ToString());
            Console.WriteLine(airConditioner.ToString());
            Console.WriteLine(musicStation.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadTask
{
    public class Vehicle(float worth, float engineVolumeCubicCentimeters) : Property(worth)
    {
        public float engineVolumeCubicCentimeters = engineVolumeCubicCentimeters;

        public override float CalculateTax()
        {
            return worth * engineVolumeCubicCentimeters / 3000f;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.Append(GetType().Name);
            builder.Append(": Cost - ");
            builder.Append(worth);
            builder.Append(", tax - ");
            builder.Append(CalculateTax());
            builder.Append(", engine volume - ");
            builder.Append(engineVolumeCubicCentimeters);
            builder.Append(" cubic centimeters");

            return builder.ToString();
        }
    }
}

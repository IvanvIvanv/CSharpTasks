using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadTask
{
    public class Immovable(float worth, float areaSqareMeters) : Property(worth)
    {
        public float areaSqareMeters = areaSqareMeters;

        public override float CalculateTax()
        {
            return areaSqareMeters switch
            {
                < 100f => worth / 500f,
                < 300f => worth / 350f,
                _ => worth / 250f
            };
        }

        public float WorthPerSquareMeter()
        {
            return worth / areaSqareMeters;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.Append(GetType().Name);
            builder.Append(": Cost - ");
            builder.Append(worth);
            builder.Append(", tax - ");
            builder.Append(CalculateTax());
            builder.Append(", area - ");
            builder.Append(areaSqareMeters);
            builder.Append(" square meters, ");
            builder.Append(WorthPerSquareMeter());
            builder.Append(" per square meter");

            return builder.ToString();
        }
    }
}

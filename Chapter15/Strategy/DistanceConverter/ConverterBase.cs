using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public abstract class ConverterBase {
        public abstract bool IsMyUnit(string name);

        //nameで与えられた谷が自分のものか確認
        protected abstract double Ratio { get; }

        public abstract string UnitName { get; }

        public double FromMeter(double meter) => meter / Ratio;

        public double ToMeter(double feet) => feet * Ratio;


    }
}

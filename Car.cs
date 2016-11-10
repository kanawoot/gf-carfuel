using System;
using System.Collections.Generic;
using System.Linq;

namespace CarFuel.Models {
    public class Car {

        public Car() {
            FillUps = new List<FillUp>();
            Make = "Make";
            Model = "Model";
        }

        public List<FillUp> FillUps { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public double? AverageConsumptionRate {

            get {


                if (FillUps.Count == 1) return null;

                double avgOdmeter = FillUps.Where(s => s.NextFillUp != null).Sum(s => (s.NextFillUp.Odometer - s.Odometer));
                double avgLiters = FillUps.Where(s => s.NextFillUp != null).Sum(s => (s.NextFillUp.Liters));
                double result = avgOdmeter / avgLiters;

                return System.Math.Round(result, 2);

                //if (FillUps.Count <= 1) {
                //    return null;
                //}

                //int? totalDistance = FillUps.Sum(f => f.Distance);
                //double? totalLiters = FillUps.Sum(f => f.Liters)
                //                    - FillUps.FirstOrDefault()?.Liters;

                //return totalDistance / totalLiters;
            }

        }

        public int Odmeter { get; set; }

        public int? Distance {

            get {

                return Odmeter - Odmeter;
            }
        }

        public FillUp AddFillUp(int odometer, double liters) {

            FillUp f = new Models.FillUp();
            f.Odometer = odometer;
            f.Liters = liters;

            if (FillUps.Count > 0) {
                FillUps[FillUps.Count - 1].NextFillUp = f;
            }

            FillUps.Add(f);

            return f;

        }



    }
}
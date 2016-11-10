using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CarFuel.Models.Facts {
    public class FillUpFact {

        public class GeneralUsage {

            [Fact]
            public void FillUp() {
                FillUp f;

                f = new FillUp();

                Assert.Equal(0, f.Odometer);
                Assert.Equal(0.0, f.Liters);
             
            }

        }

        public class ConsumptionRateProp {

          
            /*
            [Theory]
            [InlineData(1000, 40, 12.0, 1600, 50)]
            [InlineData(1600, 50, 10.0, 2200, 60)]
            public void FullFillUps_X(int od1 , double l1 , double kal1 ,
                                      int od2, double l2) {
                var f1 = new FillUp();
                f1.Odometer = od1;
                f1.Liters = l1;
                f1.IsFull = true;

                var f2 = new FillUp();
                f2.Odometer = od1;
                f2.Liters = l1;
                f2.IsFull = true;

                f1.NextFillUp = f2;

                double? result1 = f1.ConsumptionRate;
                double? result2 = f2.ConsumptionRate;

                Assert.Equal(kal1, result1);
                Assert.Null(result2);
            }
            */

            [Fact]
            public void TowFullFillUps() {
                var f1 = new FillUp();
                f1.Odometer = 1000;
                f1.Liters = 40.0;
                f1.IsFull = true;

                var f2 = new FillUp();
                f2.Odometer = 1600;
                f2.Liters = 50.0;
                f2.IsFull = true;

                f1.NextFillUp = f2;

                double? result1 = f1.ConsumptionRate;  
                double? result2 = f2.ConsumptionRate;

                Assert.Equal(12.0, result1);
                Assert.Null(result2);
            }

            [Fact]
            public void ThreeFullFillUps() {

                var f1 = new FillUp();
                f1.Odometer = 1000;
                f1.Liters = 40.0;
                f1.IsFull = true;

                var f2 = new FillUp();
                f2.Odometer = 1600;
                f2.Liters = 50.0;
                f2.IsFull = true;

                f1.NextFillUp = f2;

                var f3 = new FillUp();
                f3.Odometer = 2200;
                f3.Liters = 60.0;
                f3.IsFull = true;

                f2.NextFillUp = f3;

                double? result1 = f1.ConsumptionRate;
                double? result2 = f2.ConsumptionRate;
                double? result3 = f3.ConsumptionRate;

                Assert.Equal(12.0, result1);
                Assert.Equal(10.0, result2);
                Assert.Null(result3);
            }

        }


        



    }

}

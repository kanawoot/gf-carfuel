using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFuel.Models {

    public class FillUp {

        //public FillUp(int odometer, double liters) {
        //    Odometer = odometer;
        //    Liters = liters;
        //}

        public FillUp() { 

        }
         
        public double? ConsumptionRate {

            get {
               
                if (NextFillUp == null) {
                    return null; 
                }

                return ((NextFillUp.Odometer - Odometer) / NextFillUp.Liters);
            }
             
        }

        public int Odometer { get; set; }
        public double Liters { get; set; }
        public bool IsFull { get; set; } 
        
        public FillUp NextFillUp { get; set; }
        public int Distance { get; set; }

    }






}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversions
{
    class Conversions
    {

        public double areaConversion { get; set; }
        public double flowConversion { get; set; }
        public double lengthConversion { get; set; }
        public double temperatureConversion { get; set; }
        public double volumeConversion { get; set; }

        //empty constructor
        public Conversions()
        {

        }

        public double GetAreaConversion(areaUnitEnum from, areaUnitEnum to)
        {
            if (from == areaUnitEnum.SquareCentimeters)
            {
                if (to == areaUnitEnum.SquareCentimeters) { return 1; }
                else if (to == areaUnitEnum.SquareFeet) { return 0.001076391; }
                else if (to == areaUnitEnum.SquareInches) { return 0.15500031; }
                else if (to == areaUnitEnum.SquareKilometers) { return 1 * Math.Pow(10, -10); }
                else if (to == areaUnitEnum.SquareMeters) { return 0.0001; }
                else if (to == areaUnitEnum.SquareMiles) { return 3.8610215855 * Math.Pow(10, -11); }
                else if (to == areaUnitEnum.SquareMillimeters) { return 100; }
                else if (to == areaUnitEnum.SquareYards) { return 0.000119599; }
            }
            else if (from == areaUnitEnum.SquareFeet)
            {
                if (to == areaUnitEnum.SquareCentimeters) { return 929.0304; }
                else if (to == areaUnitEnum.SquareFeet) { return 1; }
                else if (to == areaUnitEnum.SquareInches) { return 144; }
                else if (to == areaUnitEnum.SquareKilometers) { return 9.290304 * Math.Pow(10, -8); }
                else if (to == areaUnitEnum.SquareMeters) { return 0.09290304; }
                else if (to == areaUnitEnum.SquareMiles) { return 3.5870006428 * Math.Pow(10, -8); }
                else if (to == areaUnitEnum.SquareMillimeters) { return 92903; }
                else if (to == areaUnitEnum.SquareYards) { return 0.1111; }
            }
            else if (from == areaUnitEnum.SquareInches)
            {
                if (to == areaUnitEnum.SquareCentimeters) { return 6.4516; }
                else if (to == areaUnitEnum.SquareFeet) { return 0.006944444; }
                else if (to == areaUnitEnum.SquareInches) { return 1; }
                else if (to == areaUnitEnum.SquareKilometers) { return 6.4516 * Math.Pow(10, -10); }
                else if (to == areaUnitEnum.SquareMeters) { return 0.00064516; }
                else if (to == areaUnitEnum.SquareMiles) { return 2.490976686 * Math.Pow(10, -10); }
                else if (to == areaUnitEnum.SquareMillimeters) { return 645.16; }
                else if (to == areaUnitEnum.SquareYards) { return 0.00077160493827; }
            }
            else if (from == areaUnitEnum.SquareKilometers)
            {
                if (to == areaUnitEnum.SquareCentimeters) { return 10000000000; }
                else if (to == areaUnitEnum.SquareFeet) { return 10763910.417; }
                else if (to == areaUnitEnum.SquareInches) { return 1550003100; }
                else if (to == areaUnitEnum.SquareKilometers) { return 1; }
                else if (to == areaUnitEnum.SquareMeters) { return 0.09290304; }
                else if (to == areaUnitEnum.SquareMiles) { return 0.38610215855; }
                else if (to == areaUnitEnum.SquareMillimeters) { return 1 * Math.Pow(10, 12); }
                else if (to == areaUnitEnum.SquareYards) { return 1195990.0463; }
            }
            else if (from == areaUnitEnum.SquareMeters)
            {
                if (to == areaUnitEnum.SquareCentimeters) { return 10000; }
                else if (to == areaUnitEnum.SquareFeet) { return 10.763910417; }
                else if (to == areaUnitEnum.SquareInches) { return 1550.0031; }
                else if (to == areaUnitEnum.SquareKilometers) { return .000001; }
                else if (to == areaUnitEnum.SquareMeters) { return 1; }
                else if (to == areaUnitEnum.SquareMiles) { return 3.8610215855 * Math.Pow(10, -7); }
                else if (to == areaUnitEnum.SquareMillimeters) { return 1 * Math.Pow(10, 6); }
                else if (to == areaUnitEnum.SquareYards) { return 1.1959900463; }
            }
            else if (from == areaUnitEnum.SquareMiles)
            {
                if (to == areaUnitEnum.SquareCentimeters) { return 25899881103; }
                else if (to == areaUnitEnum.SquareFeet) { return 27878400; }
                else if (to == areaUnitEnum.SquareInches) { return 4014489599.9; }
                else if (to == areaUnitEnum.SquareKilometers) { return 2.589988110; }
                else if (to == areaUnitEnum.SquareMeters) { return 2589988.110; }
                else if (to == areaUnitEnum.SquareMiles) { return 1; }
                else if (to == areaUnitEnum.SquareMillimeters) { return 2.589988110 * Math.Pow(10, 12); }
                else if (to == areaUnitEnum.SquareYards) { return 3097600; }
            }
            else if (from == areaUnitEnum.SquareMillimeters)
            {
                if (to == areaUnitEnum.SquareCentimeters) { return .01; }
                else if (to == areaUnitEnum.SquareFeet) { return 0.00001076391; }
                else if (to == areaUnitEnum.SquareInches) { return 0.0015500031; }
                else if (to == areaUnitEnum.SquareKilometers) { return 1 * Math.Pow(10, -12); }
                else if (to == areaUnitEnum.SquareMeters) { return 0.000001; }
                else if (to == areaUnitEnum.SquareMiles) { return 3.8610215855 * Math.Pow(10, -13); }
                else if (to == areaUnitEnum.SquareMillimeters) { return 1; }
                else if (to == areaUnitEnum.SquareYards) { return 0.00000119599; }
            }
            else if (from == areaUnitEnum.SquareYards)
            {
                if (to == areaUnitEnum.SquareCentimeters) { return 8361.2736; }
                else if (to == areaUnitEnum.SquareFeet) { return 9; }
                else if (to == areaUnitEnum.SquareInches) { return 1296; }
                else if (to == areaUnitEnum.SquareKilometers) { return 0.00000083612736; }
                else if (to == areaUnitEnum.SquareMeters) { return 0.83612736; }
                else if (to == areaUnitEnum.SquareMiles) { return 3.2283057852 * Math.Pow(10, -7); }
                else if (to == areaUnitEnum.SquareMillimeters) { return 836127; }
                else if (to == areaUnitEnum.SquareYards) { return 1; }
            }
            return -999; //error code that it could not find the conversion

        }

        public double GetLengthConversion(lengthUnitEnum from, lengthUnitEnum to)
        {
            if (from == lengthUnitEnum.Centimeters)
            {
                if (to == lengthUnitEnum.Centimeters) { return 1; }
                else if (to == lengthUnitEnum.Feet) { return 0.03280839895; }
                else if (to == lengthUnitEnum.Inches) { return 0.3937; }
                else if (to == lengthUnitEnum.Kilometers) { return 0.00001; }
                else if (to == lengthUnitEnum.Meters) { return 0.01; }
                else if (to == lengthUnitEnum.Miles) { return 0.0000062137119224; }
                else if (to == lengthUnitEnum.Millimeters) { return 10; }
                else if (to == lengthUnitEnum.Yards) { return 0.010936132983; }
            }
            else if (from == lengthUnitEnum.Feet)
            {
                if (to == lengthUnitEnum.Centimeters) { return 30.48; }
                else if (to == lengthUnitEnum.Feet) { return 1; }
                else if (to == lengthUnitEnum.Inches) { return 12; }
                else if (to == lengthUnitEnum.Kilometers) { return 0.0003048; }
                else if (to == lengthUnitEnum.Meters) { return 0.3048; }
                else if (to == lengthUnitEnum.Miles) { return 0.000189393939; }
                else if (to == lengthUnitEnum.Millimeters) { return 304.8; }
                else if (to == lengthUnitEnum.Yards) { return 0.33333; }
            }
            else if (from == lengthUnitEnum.Inches)
            {
                if (to == lengthUnitEnum.Centimeters) { return 2.54; }
                else if (to == lengthUnitEnum.Feet) { return 0.08333; }
                else if (to == lengthUnitEnum.Inches) { return 1; }
                else if (to == lengthUnitEnum.Kilometers) { return 0.0000254; }
                else if (to == lengthUnitEnum.Meters) { return 0.0254; }
                else if (to == lengthUnitEnum.Miles) { return 0.000015782828283; }
                else if (to == lengthUnitEnum.Millimeters) { return 24.4; }
                else if (to == lengthUnitEnum.Yards) { return 0.0277778; }
            }
            else if (from == lengthUnitEnum.Kilometers)
            {
                if (to == lengthUnitEnum.Centimeters) { return 100000; }
                else if (to == lengthUnitEnum.Feet) { return 3280.839895; }
                else if (to == lengthUnitEnum.Inches) { return 39370; }
                else if (to == lengthUnitEnum.Kilometers) { return 1; }
                else if (to == lengthUnitEnum.Meters) { return 1000; }
                else if (to == lengthUnitEnum.Miles) { return 0.62137119224; }
                else if (to == lengthUnitEnum.Millimeters) { return 1000000; }
                else if (to == lengthUnitEnum.Yards) { return 1093.6132983; }
            }
            else if (from == lengthUnitEnum.Meters)
            {

                if (to == lengthUnitEnum.Centimeters) { return 100; }
                else if (to == lengthUnitEnum.Feet) { return 3.280839895; }
                else if (to == lengthUnitEnum.Inches) { return 39.370; }
                else if (to == lengthUnitEnum.Kilometers) { return 1000; }
                else if (to == lengthUnitEnum.Meters) { return 1; }
                else if (to == lengthUnitEnum.Miles) { return 0.00062137119224; }
                else if (to == lengthUnitEnum.Millimeters) { return 1000; }
                else if (to == lengthUnitEnum.Yards) { return 1.0936132983; }

            }
            else if (from == lengthUnitEnum.Miles)
            {
                if (to == lengthUnitEnum.Centimeters) { return 160934.4; }
                else if (to == lengthUnitEnum.Feet) { return 5280; }
                else if (to == lengthUnitEnum.Inches) { return 63600; }
                else if (to == lengthUnitEnum.Kilometers) { return 1.609344; }
                else if (to == lengthUnitEnum.Meters) { return 1609.344; }
                else if (to == lengthUnitEnum.Miles) { return 1; }
                else if (to == lengthUnitEnum.Millimeters) { return 1609344; }
                else if (to == lengthUnitEnum.Yards) { return 1760; }
            }
            else if (from == lengthUnitEnum.Millimeters)
            {
                if (to == lengthUnitEnum.Centimeters) { return .1; }
                else if (to == lengthUnitEnum.Feet) { return 0.003280839895; }
                else if (to == lengthUnitEnum.Inches) { return .03937; }
                else if (to == lengthUnitEnum.Kilometers) { return 0.000001; }
                else if (to == lengthUnitEnum.Meters) { return 0.001; }
                else if (to == lengthUnitEnum.Miles) { return 0.00000062137119224; }
                else if (to == lengthUnitEnum.Millimeters) { return 1; }
                else if (to == lengthUnitEnum.Yards) { return 0.0010936132983; }
            }
            else if (from == lengthUnitEnum.Yards)
            {
                if (to == lengthUnitEnum.Centimeters) { return 91.44; }
                else if (to == lengthUnitEnum.Feet) { return 3; }
                else if (to == lengthUnitEnum.Inches) { return 36; }
                else if (to == lengthUnitEnum.Kilometers) { return 0.0009144; }
                else if (to == lengthUnitEnum.Meters) { return 0.9144; }
                else if (to == lengthUnitEnum.Miles) { return 0.0005681818; }
                else if (to == lengthUnitEnum.Millimeters) { return 914.4; }
                else if (to == lengthUnitEnum.Yards) { return 1; }
            }
            return -999;
        }

        public double GetVolumeUnitConversion(volumeUnitEnum from, volumeUnitEnum to)
        {
            if (from == volumeUnitEnum.CubicCentimeters)
            {
                if (to == volumeUnitEnum.CubicCentimeters) { return 1; }
                else if (to == volumeUnitEnum.CubicFeet) { return 0.000035314666; }
                else if (to == volumeUnitEnum.CubicInches) { return 0.061023744; }
                else if (to == volumeUnitEnum.CubicKilometers) { return 1 * Math.Pow(10, -15); }
                else if (to == volumeUnitEnum.CubicMeters) { return 1 * Math.Pow(10, -6); }
                else if (to == volumeUnitEnum.CubicMiles) { return 2.3991275858 * Math.Pow(10, -16); }
                else if (to == volumeUnitEnum.CubicMillimeters) { return 1000; }
                else if (to == volumeUnitEnum.CubicYards) { return 1.3079506193 * Math.Pow(10, -6); }
            }
            else if (from == volumeUnitEnum.CubicFeet)
            {
                if (to == volumeUnitEnum.CubicCentimeters) { return 28316.846592; }
                else if (to == volumeUnitEnum.CubicFeet) { return 1; }
                else if (to == volumeUnitEnum.CubicInches) { return 1728; }
                else if (to == volumeUnitEnum.CubicKilometers) { return 2.8316846592 * Math.Pow(10, -11); }
                else if (to == volumeUnitEnum.CubicMeters) { return 0.028316846592; }
                else if (to == volumeUnitEnum.CubicMiles) { return 6.7935727802 * Math.Pow(10, -12); }
                else if (to == volumeUnitEnum.CubicMillimeters) { return 28316846.592; }
                else if (to == volumeUnitEnum.CubicYards) { return 0.037037037; }
            }
            else if (from == volumeUnitEnum.CubicInches)
            {
                if (to == volumeUnitEnum.CubicCentimeters) { return 16.387064; }
                else if (to == volumeUnitEnum.CubicFeet) { return 0.000578703; }
                else if (to == volumeUnitEnum.CubicInches) { return 1; }
                else if (to == volumeUnitEnum.CubicKilometers) { return 1.6387064 * Math.Pow(10, -14); }
                else if (to == volumeUnitEnum.CubicMeters) { return 0.000016387064; }
                else if (to == volumeUnitEnum.CubicMiles) { return 3.9314657293 * Math.Pow(10, -15); }
                else if (to == volumeUnitEnum.CubicMillimeters) { return 16387.064; }
                else if (to == volumeUnitEnum.CubicYards) { return 0.000021433470508; }
            }
            else if (from == volumeUnitEnum.CubicKilometers)
            {
                if (to == volumeUnitEnum.CubicCentimeters) { return 1 * Math.Pow(10, 15); }
                else if (to == volumeUnitEnum.CubicFeet) { return 35314666721; }
                else if (to == volumeUnitEnum.CubicInches) { return 61023744095000; }
                else if (to == volumeUnitEnum.CubicKilometers) { return 1; }
                else if (to == volumeUnitEnum.CubicMeters) { return 1 * Math.Pow(10, 9); }
                else if (to == volumeUnitEnum.CubicMiles) { return 2.3991275858 * Math.Pow(10, -1); }
                else if (to == volumeUnitEnum.CubicMillimeters) { return 1 * Math.Pow(10, 18); }
                else if (to == volumeUnitEnum.CubicYards) { return 1307950619.3 * Math.Pow(10, -6); }
            }
            else if (from == volumeUnitEnum.CubicMeters)
            {
                if (to == volumeUnitEnum.CubicCentimeters) { return 1000000; }
                else if (to == volumeUnitEnum.CubicFeet) { return 35.314666721; }
                else if (to == volumeUnitEnum.CubicInches) { return 61023.744095; }
                else if (to == volumeUnitEnum.CubicKilometers) { return 1 * Math.Pow(10, -9); }
                else if (to == volumeUnitEnum.CubicMeters) { return 1; }
                else if (to == volumeUnitEnum.CubicMiles) { return 2.3991275858 * Math.Pow(10, -10); }
                else if (to == volumeUnitEnum.CubicMillimeters) { return 1 * Math.Pow(10, 9); }
                else if (to == volumeUnitEnum.CubicYards) { return 13079506193 * Math.Pow(10, -6); }
            }
            else if (from == volumeUnitEnum.CubicMiles)
            {
                if (to == volumeUnitEnum.CubicCentimeters) { return 4168181825400000; }
                else if (to == volumeUnitEnum.CubicFeet) { return 147197952000; }
                else if (to == volumeUnitEnum.CubicInches) { return 254358061050000; }
                else if (to == volumeUnitEnum.CubicKilometers) { return 4.1681818254; }
                else if (to == volumeUnitEnum.CubicMeters) { return 4168181825.4; }
                else if (to == volumeUnitEnum.CubicMiles) { return 1; }
                else if (to == volumeUnitEnum.CubicMillimeters) { return 4168181825400000000; }
                else if (to == volumeUnitEnum.CubicYards) { return 5451776000; }
            }
            else if (from == volumeUnitEnum.CubicMillimeters)
            {
                if (to == volumeUnitEnum.CubicCentimeters) { return .001; }
                else if (to == volumeUnitEnum.CubicFeet) { return 0.000000035314666; }
                else if (to == volumeUnitEnum.CubicInches) { return 0.000061023744; }
                else if (to == volumeUnitEnum.CubicKilometers) { return 1 * Math.Pow(10, -18); }
                else if (to == volumeUnitEnum.CubicMeters) { return 1 * Math.Pow(10, -9); }
                else if (to == volumeUnitEnum.CubicMiles) { return 2.3991275858 * Math.Pow(10, -19); }
                else if (to == volumeUnitEnum.CubicMillimeters) { return 1; }
                else if (to == volumeUnitEnum.CubicYards) { return 1.3079506193 * Math.Pow(10, -9); }
            }
            else if (from == volumeUnitEnum.CubicYards)
            {
                if (to == volumeUnitEnum.CubicCentimeters) { return 764554.85798; }
                else if (to == volumeUnitEnum.CubicFeet) { return 27; }
                else if (to == volumeUnitEnum.CubicInches) { return 46656; }
                else if (to == volumeUnitEnum.CubicKilometers) { return 7.6455485798 * Math.Pow(10, -10); }
                else if (to == volumeUnitEnum.CubicMeters) { return 0.76455485798; }
                else if (to == volumeUnitEnum.CubicMiles) { return 1.8342646506 * Math.Pow(10, -10); }
                else if (to == volumeUnitEnum.CubicMillimeters) { return 764554857.98; }
                else if (to == volumeUnitEnum.CubicYards) { return 1; }
            }
            return -999;
        }

        public enum areaUnitEnum
        {
            SquareKilometers,
            SquareMeters,
            SquareCentimeters,
            SquareMillimeters,
            SquareMiles,
            SquareYards,
            SquareFeet,
            SquareInches
        }

        enum flowUnitEnum
        {
            CFM,
            CubicMPerHr,
            LPerSec,
            LPM,
            GPH,
            GPM
        }

        public enum lengthUnitEnum
        {
            Kilometers,
            Meters,
            Centimeters,
            Millimeters,
            Miles,
            Yards,
            Feet,
            Inches
        }

        enum temperatureUnitEnum
        {
            F,
            C,
            K,
            R
        }

        public enum volumeUnitEnum
        {
            CubicKilometers,
            CubicMeters,
            CubicCentimeters,
            CubicMillimeters,
            CubicMiles,
            CubicYards,
            CubicFeet,
            CubicInches
        }

    }


}

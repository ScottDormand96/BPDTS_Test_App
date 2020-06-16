using System;
using BPDTSTestApp.Services.Interfaces;

namespace BPDTSTestApp.Services
{
    public class DistanceService : IDistanceService
    {
        public double LocationDistance(double latitudeLocationOne, double longitudeLocationOne, double latitudeLocationTwo, double longitudeLocationTwo)
        {
            double distanceMiles = 3960; //Miles

            var latitude = ConvertToRadians(latitudeLocationTwo - latitudeLocationOne);
            var longitude = ConvertToRadians(longitudeLocationTwo - longitudeLocationOne);

            latitudeLocationOne = ConvertToRadians(latitudeLocationOne);
            latitudeLocationTwo = ConvertToRadians(latitudeLocationTwo);


            var longitudeLocationCalc = Math.Sin(latitude / 2) * Math.Sin(latitude / 2) + Math.Sin(longitude / 2) * Math.Sin(longitude / 2) * Math.Cos(latitudeLocationOne) * Math.Cos(latitudeLocationTwo);

            return distanceMiles * 2 * Math.Asin(Math.Sqrt(longitudeLocationCalc));
        }

        private static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}
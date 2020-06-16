namespace BPDTSTestApp.Services.Interfaces
{
    public interface IDistanceService
    {
        double LocationDistance(double latitudeLocationOne, double longitudeLocationOne, double latitudeLocationTwo, double longitudeLocationTwo);
    }
}
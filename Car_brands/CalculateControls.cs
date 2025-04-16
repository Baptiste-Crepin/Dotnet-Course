namespace Car_brands;

public class CalculateControls
{
    public static int CalculateNumberOfControlsToDate(int year)
    {
        const int yearAfterFirstControl = 4;
        const int yearsBetweenEveryControl = 2;

        var today = DateTime.Today;
        var numberOfControls = 0;

        var vehicleAge = today.Year - year;

        if (vehicleAge < 0) return numberOfControls;

        if (today.Year < vehicleAge + yearAfterFirstControl) return numberOfControls;

        numberOfControls += 1;
        var vehicleAgeMinusFirstControl = vehicleAge - yearAfterFirstControl;

        numberOfControls += vehicleAgeMinusFirstControl / yearsBetweenEveryControl;

        return numberOfControls;
    }
}
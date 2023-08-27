using System;

namespace pathfinder { 

public class travel
{
    public struct coord //inates, used to simplify saving of precise location data
    {
        public void Coords(double Latitude, double Longitude, string cntrycode)
        {  // import and set for struct
            this.latitude = Latitude;
            this.longitude = Longitude;
            this.countrycode = cntrycode;
        }
        public double latitude { get; set; } // first number in a GPS/GLONASS/etc coordinate string
        public double longitude { get; set; } // second number in a GPS/GLONASS/etc coordinate string
        public string countrycode { get; set; } //intended for ISO 3166-1 alpha-3 codes
        // TODO: https://gist.github.com/tadast/8827699 turn this into a data file that i can import data from ---JS 20230826
        // public override readonly string ToString() => $"({latitude}, {longitude})";
        // lamnda function to spit out quick coords for later api integration, can not change structure data ---JS 20230826
    }

    public struct AirTravel
    { // import and set for struct
        public void AirTravelsetter(string strtPortCode, string destPortCode) // https://www.iata.org/en/publications/directories/code-search <= for IATA codes
        { // need to choose between 3 letter IATA codes or 4 letter ICAO codes
            this.startingairportcode = strtPortCode;
            this.destinationairportcode = destPortCode;
        } // https://airportcodes.aero/ <= for ICAO codes
        public string startingairportcode { get; set; }
        public string destinationairportcode { get; set; }
        public readonly override string ToString() => $"({startingairportcode}, {destinationairportcode})";
    }

    public void travelflight(string ccode0, string ccode1)
    {   // flight paths
        //var flightpath = AirTravelsetter(string start, string final);
        string startcountry = ccode0;
        string finalcountry = ccode1;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        bool isAovernight(bool result) => isovernight = result;

        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        bool isAintltravel (bool result) => isintltravel = result;

    }

    public void traveltrain(double lat0, double lon0, string ccode0, double lat1, double lon1, string ccode1)
    {
        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        bool isAintltravel(bool result) => isintltravel = result;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        bool isAovernight(bool result) => isovernight = result;

        //var startlocation = coord.Coords(lat0, lon0, ccode0);
        //var finallocation = coord(lat1, lon1, ccode1);
    }

    public void travelbus(double lat0, double lon0, string ccode0, double lat1, double lon1, string ccode1)
    {
        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        bool isAintltravel(bool result) => isintltravel = result;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        bool isAovernight(bool result) => isovernight = result;

        //var startlocation = coord(lat0, lon0, ccode0);
        //var finallocation = coord(lat1, lon1, ccode1);
    }

    public void travelauto(double lat0, double lon0, string ccode0, double lat1, double lon1, string ccode1)
    {
        bool isRental; // if the car is the traveler's rental or not
        bool isPersonal; // if the car is the traveler's personal rental
        // set functions
        bool isARental(bool result) => isRental = result;
        bool isAPersonal(bool result) => isRental = result;

        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        bool isAintltravel(bool result) => isintltravel = result;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        bool isAovernight(bool result) => isovernight = result;

        //var startlocation = coord(lat0, lon0, ccode0);
        //var finallocation = coord(lat1, lon1, ccode1);
    }
    /*
    public void Testitem(string teststring0);
    {
        string this.teststring = teststring0;
    }
    */
    }
}
using System;

namespace pathfinder { 

public class travel
{
    public struct coord //inates, used to simplify saving of precise location data
    {
        public static string[] Coords(string Latitude, string Longitude, string cntrycode)
        {  // import and set for struct
            latitude = Latitude;
            longitude = Longitude;
            countrycode = cntrycode;
            string[] coordinates = { latitude, longitude, countrycode };
            return coordinates;
        }
        public static string latitude { get; set; } // first number in a GPS/GLONASS/etc coordinate string
        public static string longitude { get; set; } // second number in a GPS/GLONASS/etc coordinate string
        public static string countrycode { get; set; } //intended for ISO 3166-1 alpha-3 codes
        // TODO: https://gist.github.com/tadast/8827699 turn this into a data file that i can import data from ---JS 20230826
        // public override readonly string ToString() => $"({latitude}, {longitude})";
        // lamnda function to spit out quick coords for later api integration, can not change structure data ---JS 20230826
    }

    public struct AirTravel
    { // import and set for struct
        public static string startingairportcode { get; set; }
        public static string destinationairportcode { get; set; }
        public static string[] AirTravelsetter(string strtPortCode, string destPortCode) // https://www.iata.org/en/publications/directories/code-search <= for IATA codes
        { // need to choose between 3 letter IATA codes or 4 letter ICAO codes
            startingairportcode = strtPortCode;
            destinationairportcode = destPortCode;
            string[] ports = { strtPortCode, destPortCode };
            return ports;
        } // https://airportcodes.aero/ <= for ICAO codes
        // may not be needed, alternatively may need refactoring ---js 20230827
        public readonly override string ToString() => $"({startingairportcode}, {destinationairportcode})";
    }

    public void travelflight(string ccode0, string ccode1)
    {   // flight paths
        string startcountry = ccode0;
        string finalcountry = ccode1;
        var flightpath = AirTravel.AirTravelsetter(startcountry, finalcountry);

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        bool isAovernight(bool result) => isovernight = result; // call a function like this instead of the normal way

        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        bool isAintltravel (bool result) => isintltravel = result;

    }

    public void traveltrain(string lat0, string lon0, string ccode0, string lat1, string lon1, string ccode1)
    {
        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        bool isAintltravel(bool result) => isintltravel = result;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        bool isAovernight(bool result) => isovernight = result;

        var startlocation = coord.Coords(lat0, lon0, ccode0);
        //var finallocation = coord(lat1, lon1, ccode1);
    }

    public void travelbus(string lat0, string lon0, string ccode0, string lat1, string lon1, string ccode1)
    {
        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        bool isAintltravel(bool result) => isintltravel = result;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        bool isAovernight(bool result) => isovernight = result;

        //var startlocation = coord(lat0, lon0, ccode0);
        //var finallocation = coord(lat1, lon1, ccode1);
    }

    public void travelauto(string lat0, string lon0, string ccode0, string lat1, string lon1, string ccode1)
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
using System;

namespace WindowsFormsApp1;

public class travel
{
    public struct coord //inates, used to simplify saving of precise location data
    {
        public Coords(double Latitude, double Longitude, string cntrycode)
        {  // import and set for struct
            latitude = Latitude;
            longitude = Longitude;
            countrycode = cntrycode;
        }
        public double latitude { get; } // first number in a GPS/GLONASS/etc coordinate string
        public double longitude { get; } // second number in a GPS/GLONASS/etc coordinate string
        public string countrycode { get; } //intended for ISO 3166-1 alpha-3 codes
        // TODO: https://gist.github.com/tadast/8827699 turn this into a data file that i can import data from ---JS 20230826
        public readonly override string ToString() => $"({latitude}, {longitude})"; 
        // lamnda function to spit out quick coords for later api integration, can not change structure data ---JS 20230826
    }

    public struct airTravel()
    { // import and set for struct
        public pointToPoint(string strtPortCode, string destPortCode) // https://www.iata.org/en/publications/directories/code-search <= for IATA codes
        { // need to choose between 3 letter IATA codes or 4 letter ICAO codes
            startingairportcode = strtPortCode;
            destinationairportcode = destPortCode;
        } // https://airportcodes.aero/ <= for ICAO codes
        public string startingairportcode { get; }
        public string destinationairportcode { get; }
        public readonly override string ToString() => $"({startingairportcode}, {destinationairportcode})";
    }

	public travel-flight(string ccode0, string ccode1)
	{   // flight paths
        var flightpath = airTravel(string start, string final);
        string startcountry = ccode0;
        string final country = ccode1;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        public set isAovernight(bool result) => isovernight = result;

        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        public set isAintltravel(bool result) => isintltravel = result;

    }

    public travel-train(double lat0, double lon0, string ccode0, double lat1, double lon1, string ccode1)
    {
        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        public set isAintltravel(bool result) => isintltravel = result;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        public set isAovernight(bool result) => isovernight = result;

        var startlocation = coord(lat0, lon0, ccode0);
        var finallocation = coord(lat1, lon1, ccode1);
    }

    public travel-bus(double lat0, double lon0, string ccode0, double lat1, double lon1, string ccode1)
    {
        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        public set isAintltravel(bool result) => isintltravel = result;
        
        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        public set isAovernight(bool result) => isovernight = result;

        var startlocation = coord(lat0, lon0, ccode0);
        var finallocation = coord(lat1, lon1, ccode1);
    }

    public travel-auto(double lat0, double lon0,string ccode0, double lat1, double lon1, string ccode1)
    {
        bool isRental; // if the car is the traveler's rental or not
        bool isPersonal; // if the car is the traveler's personal rental
        // set functions
        public set isARental (bool result) => isRental = result;
        public set isAPersonal (bool result) => isRental = result;

        bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area
        public set isAintltravel(bool result) => isintltravel = result;

        bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
        public set isAovernight(bool result) => isovernight = result;

        var startlocation = coord(lat0, lon0, ccode0);
        var finallocation = coord(lat1, lon1, ccode1);
    }

    /* copy paste
     * public travel-flight()
     * {
     * }
     */
}

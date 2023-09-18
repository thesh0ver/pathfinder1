using System;
using System.Data.Common;

namespace pathfinder { 
	// praise whatever God(s) you choose or don't, regardless, pls pls pls pls!! do not remove static keywords!!!!! ---JS 20230827
public class travel
{// string destinationtypes is here so it can be seen from other files upon build ---JS20230918
	public static string[] overnightdestinationtypes = { "Hotel", "Motel", "Short-Term Rental", "Campsite", "RV Park" };
	public static string[] destinationtypes = { "Other", "Park", "Muesem" };

    public struct coord //inates, used to simplify saving of precise location data ---JS 20230827
		{
		public static string[] Coords(string Latitude, string Longitude, string cntrycode)
		{  // import and set for struct
			latitude = Latitude;
			longitude = Longitude;
			countrycode = cntrycode;
			string[] coordinates = { latitude, longitude, countrycode };
			return coordinates;
		}
		public static string latitude { get; set; } // first number in a GPS/GLONASS/etc coordinate string ---JS 20230827
		public static string longitude { get; set; } // second number in a GPS/GLONASS/etc coordinate string ---JS 20230827
		public static string countrycode { get; set; } //intended for ISO 3166-1 alpha-3 codes
		// TODO: https://gist.github.com/tadast/8827699 turn this into a data file that i can import data from ---JS 20230826
		// public override readonly string ToString() => $"({latitude}, {longitude})";---JS 20230827
		// lamnda function to spit out quick coords for later api integration, can not change structure data ---JS 20230826
		public readonly string coordstostring() => $"({latitude}, {longitude}, {countrycode})"; //suboptimal, but necessary ---JS 20230918
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
	public struct overnightdestination
	{
		public string setovernightdestinationtype(int code)
		{// sets type of destination traveller(s) rest at, must be extended later ---JS 20230918
		 // I nearly wrote a FUCKING SWITCH statement til I thought of this im a so so so foolish ---JS 20230918
			return travel.overnightdestinationtypes[code];
		}
		public string nameofdest { get; set; }
		public string typeofdestination { get; set; }
		public string weblink { get; set; }
        public coord locationofdest { get; set; } // should be able to use coordstostring() to fetch strings, may not be needed, but just in case ---JS 20230918
		public readonly string fetchnameofdest() => $"{nameofdest}";
		public readonly string fetchtypeofdestination() => $"{typeofdestination}";
		public readonly string fetchweblink() => $"{weblink}";
        //public readonly string fetchlocationofdest => $"{nameofdest}";
		//public readonly string fetchnameofdest => $"{nameofdest}";
    }
	public struct destination
	{ // for day activities and non overnight stays ---JS 20230918
		public string setdestinationtype(int code) {
			return travel.destinationtypes[code];
        }
		public string nameofdest { get; set; }
		public string typeofdestination { get; set; }
		public readonly string fetchnameofdest() => $"{nameofdest}";
		public readonly string fetchtypeofdestination() => $"{typeofdestination}";
	}

	public void createdest()
	{
			// TBW ---JS 20230918
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
		bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area ---JS 20230827
		bool isAintltravel(bool result) => isintltravel = result;

		bool isovernight; // if the travel method happens overnight and requires a sleeper bunk
		bool isAovernight(bool result) => isovernight = result;

		var startlocation = coord.Coords(lat0, lon0, ccode0);
		//var finallocation = coord(lat1, lon1, ccode1);
	}

	public void travelbus(string lat0, string lon0, string ccode0, string lat1, string lon1, string ccode1)
	{
		bool isintltravel; // if the country passes between countries, may not be optimal for special travel agreements, such as the Schengen area ---JS 20230827
		bool isAintltravel(bool result) => isintltravel = result;

		bool isovernight; // if the travel method happens overnight and requires a sleeper bunk ---JS 20230827
		bool isAovernight(bool result) => isovernight = result;

		var startlocation = coord.Coords(lat0, lon0, ccode0); 
		var finallocation = coord.Coords(lat1, lon1, ccode1);
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

		var startlocation = coord.Coords(lat0, lon0, ccode0); 
		var finallocation = coord.Coords(lat1, lon1, ccode1);
	}
	
	
	
	}
}
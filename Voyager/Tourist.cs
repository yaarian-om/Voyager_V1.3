using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager
{
    class Tourist
    {

        #region Basic

        #endregion Basic


        #region TravelInfo
        private static string travelLocation = null;
        private static int travelPhotoIndex = -1;
        private static string vehicleType;
        private static string vehicleName = null;
        private static string travelDate;
        private static string departureTime;
        private static string vehicleClass = null;
        private static double vehicleCost;
        private static int passengers = 1;
        private static string zilla;
        private static bool busAC;
        private static bool railAC;
        #endregion TravelInfo

        #region TravelInfo Setter Getter Methods
        public static string TravelLocation { get => travelLocation; set => travelLocation = value; }
        public static int TravelPhotoIndex { get => travelPhotoIndex; set => travelPhotoIndex = value; }
        public static string VehicleType { get => vehicleType; set => vehicleType = value; }
        public static string VehicleName { get => vehicleName; set => vehicleName = value; }
        public static string TravelDate { get => travelDate; set => travelDate = value; }
        public static string DepartureTime { get => departureTime; set => departureTime = value; }
        public static string VehicleClass { get => vehicleClass; set => vehicleClass = value; }
        public static double Cost { get => vehicleCost; set => vehicleCost = value; }
        public static int Passengers { get => passengers; set => passengers = value; }
        public static string Zilla { get => zilla; set => zilla = value; }
        public static bool BusAC { get => busAC; set => busAC = value; }
        public static bool RailAC { get => railAC; set => railAC = value; }
        #endregion Setter Getter Methods

        #region HotelInfo
        private static string hotelName;
        private static double hotelCost;
        public static string HotelName{get => hotelName; set => hotelName = value;}
        #endregion HotelInfo

        #region DataBase Connection

        #endregion DataBase Connection



        #region Cost Calculation







        #region Cost
        // In real-life these will be dynamic too by using arrays like Zilla-Wise Cost Collection
        private static double firstClassPrice = 2000;
        private static double businessClassPrice = 1000;
        private static double economicClassPrice = 0;
        private static double acPrice = 200;
        #region Zilla-Wise Cost Collection =>> AIR, BUS, RAIL
        private static double[] Bandarban = { 3000, 550, 300 };
        private static double[] Sylhet = { 2500, 400, 160 };
        private static double[] Rangamati = { 0, 450, 0} ;
        private static double[] Netrokona = { 0, 320, 165 };
        private static double[] Dhaka = { 0, 150, 0 };
        private static double[] Comilla = { 1800, 300, 205 };
        private static double[] Bogra = { 2700, 400, 330 };
        private static double[] CoxsBazar = { 4500, 900, 0 };
        private static double[] Patuakhali = { 2000, 600, 0 };
        private static double[] Chittagong = { 2600, 580, 345 };
        private static double[] Shunamgonj = { 0, 500, 0 };
        #endregion Zilla-Wise Cost Collection =>> AIR, BUS, RAIL

        #endregion Cost



        public static string getVehicleCost(string place, bool air, string classs, bool bus, bool rail, bool ac)
        {
            // Air = 0, Bus = 1, Rail = 2
            switch (place)
            {
                case "Bandarban":
                    {
                        int pos = 0;
                        if (air == true)
                        {
                            if(classs == "First Class")
                            {
                                vehicleCost = Bandarban[0] * firstClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if(classs == "Business Class")
                            {
                                vehicleCost = Bandarban[0] + businessClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Economy Class")
                            {
                                vehicleCost = Bandarban[0] + economicClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if(bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Bandarban[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if(ac == false)
                            {
                                vehicleCost = Bandarban[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (rail == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Bandarban[2] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Bandarban[2];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        break;
                    }
                case "Sylhet":
                    {
                        int pos = 1;
                        if (air == true)
                        {
                            if (classs == "First Class")
                            {

                                vehicleCost = Sylhet[0] + firstClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Business Class")
                            {
                                vehicleCost = Sylhet[0] + businessClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Economy Class")
                            {
                                vehicleCost = Sylhet[0] + economicClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Sylhet[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Sylhet[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (rail == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Sylhet[2] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Sylhet[2];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        break;
                    }
                case "Rangamati":
                    {
                        int pos = 2;
                        
                        if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Rangamati[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Rangamati[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        
                        break;
                    }
                case "Netrokona":
                    {
                        int pos = 3;

                        if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Netrokona[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Netrokona[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (rail == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Netrokona[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Netrokona[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        break;
                    }
                case "Dhaka":
                    {
                        int pos = 4;
                        
                        if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Dhaka[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Dhaka[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        
                        break;
                    }
                case "Comilla":
                    {
                        int pos = 5;
                        if (air == true)
                        {
                            if (classs == "First Class")
                            {

                                vehicleCost = Comilla[0] + firstClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Business Class")
                            {
                                vehicleCost = Comilla[0] + businessClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Economy Class")
                            {
                                vehicleCost = Comilla[0] + economicClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Comilla[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Comilla[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (rail == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Comilla[2] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Comilla[2];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        break;
                    }
                case "Bogra":
                    {
                        int pos = 6;
                        if (air == true)
                        {
                            if (classs == "First Class")
                            {

                                vehicleCost = Bogra[0] + firstClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Business Class")
                            {
                                vehicleCost = Bogra[0] + businessClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Economy Class")
                            {
                                vehicleCost = Bogra[0] + economicClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Bogra[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Bogra[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (rail == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Bogra[2] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Bogra[2];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        break;
                    }
                case "Cox's Bazar":
                    {
                        int pos = 7;
                        if (air == true)
                        {
                            if (classs == "First Class")
                            {

                                vehicleCost = CoxsBazar[0] + firstClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Business Class")
                            {
                                vehicleCost = CoxsBazar[0] + businessClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Economy Class")
                            {
                                vehicleCost = CoxsBazar[0] + economicClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = CoxsBazar[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = CoxsBazar[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        
                        break;
                    }
                case "Patuakhali":
                    {
                        int pos = 8;
                        if (air == true)
                        {
                            if (classs == "First Class")
                            {

                                vehicleCost = Patuakhali[0] + firstClassPrice;
                                Console.WriteLine("Vehicle Cost in Tourist = "+ vehicleCost);
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Business Class")
                            {
                                vehicleCost = Patuakhali[0] + businessClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Economy Class")
                            {
                                vehicleCost = Patuakhali[0] + economicClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Patuakhali[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Patuakhali[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        
                        break;
                    }
                case "Chittagong":
                    {
                        int pos = 9;
                        if (air == true)
                        {
                            if (classs == "First Class")
                            {

                                vehicleCost = Chittagong[0] + firstClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Business Class")
                            {
                                vehicleCost = Chittagong[0] + businessClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (classs == "Economy Class")
                            {
                                vehicleCost = Chittagong[0] + economicClassPrice;
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Chittagong[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Chittagong[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        else if (rail == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Chittagong[2] +acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Chittagong[2];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        break;
                    }
                case "Shunamgonj":
                    {
                        int pos = 10;
                       
                        if (bus == true)
                        {
                            if (ac == true)
                            {
                                vehicleCost = Shunamgonj[1] + acPrice;
                                return Convert.ToString(vehicleCost);
                            }
                            else if (ac == false)
                            {
                                vehicleCost = Shunamgonj[1];
                                return Convert.ToString(vehicleCost);
                            }
                        }
                        
                        break;
                    }
                

            }
            return Convert.ToString(vehicleCost);
        }


        public static double totalCost()
        {
            return vehicleCost + hotelCost;
        }

        #endregion Cost Calculation

        
        


    }
}

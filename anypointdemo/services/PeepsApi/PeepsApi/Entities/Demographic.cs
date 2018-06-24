using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeepsApi.Entities
{

    public class Demographic
    {
        public Ethnicities Ethnicities { get; set; }
        public Age Age { get; set; }
        public Miscellaneous Miscellaneous { get; set; }
        public Sales Sales { get; set; }
        public string State { get; set; }
        public Income Income { get; set; }
        public Education Education { get; set; }
        public Employment Employment { get; set; }
        public Housing Housing { get; set; }
        public Population Population { get; set; }
    }

    public class Ethnicities
    {
        public float WhiteAlonenotHispanicorLatino { get; set; }
        public float TwoorMoreRaces { get; set; }
        public float AsianAlone { get; set; }
        public float NativeHawaiianandOtherPacificIslanderAlone { get; set; }
        public float WhiteAlone { get; set; }
        public float HispanicorLatino { get; set; }
        public float BlackAlone { get; set; }
        public float AmericanIndianandAlaskaNativeAlone { get; set; }
    }

    public class Age
    {
        public float PercentUnder18Years { get; set; }
        public float Percent65andOlder { get; set; }
        public float PercentUnder5Years { get; set; }
    }

    public class Miscellaneous
    {
        public int ManufacturersShipments { get; set; }
        public float ForeignBorn { get; set; }
        public float PercentFemale { get; set; }
        public float LanguageOtherthanEnglishatHome { get; set; }
        public float LivinginSameHouse1Years { get; set; }
        public float MeanTravelTimetoWork { get; set; }
        public int BuildingPermits { get; set; }
        public int Veterans { get; set; }
        public float LandArea { get; set; }
    }

    public class Sales
    {
        public int RetailSales { get; set; }
        public int MerchantWholesalerSales { get; set; }
        public int AccommodationandFoodServicesSales { get; set; }
        public int RetailSalesperCapita { get; set; }
    }

    public class Income
    {
        public int MedianHouseoldIncome { get; set; }
        public int PerCapitaIncome { get; set; }
        public float PersonsBelowPovertyLevel { get; set; }
    }

    public class Education
    {
        public float BachelorsDegreeorHigher { get; set; }
        public float HighSchoolorHigher { get; set; }
    }

    public class Employment
    {
        public int PrivateNonfarmEstablishments { get; set; }
        public float PrivateNonfarmEmploymentPercentChange { get; set; }
        public Firms Firms { get; set; }
        public int NonemployerEstablishments { get; set; }
        public int PrivateNonfarmEmployment { get; set; }
    }

    public class Firms
    {
        public int Total { get; set; }
        public float HispanicOwned { get; set; }
        public float NativeHawaiianandOtherPacificIslanderOwned { get; set; }
        public float AmericanIndianOwned { get; set; }
        public float BlackOwned { get; set; }
        public float AsianOwned { get; set; }
        public float WomenOwned { get; set; }
    }

    public class Housing
    {
        public int HousingUnits { get; set; }
        public float UnitsinMultiUnitStructures { get; set; }
        public int MedianValueofOwnerOccupiedUnits { get; set; }
        public int Households { get; set; }
        public float PersonsperHousehold { get; set; }
        public float HomeownershipRate { get; set; }
    }

    public class Population
    {
        public int _2014Population { get; set; }
        public int _2010Population { get; set; }
        public float PopulationperSquareMile { get; set; }
        public float PopulationPercentChange { get; set; }
    }

}
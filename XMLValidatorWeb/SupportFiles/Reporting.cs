using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMLValidatorWeb.SupportFiles
{
    public class Dimension
    {
        public double measure { get; set; }
        public string units { get; set; }
    }

    public class Length: Dimension
    {

    }

    public class Area:Dimension
    {
        public Area(double input, string uom)
        {
            measure = input;
            units = uom;
        }
    }

    public class BasicSummary
    {
        public string FileType { get; set; } //standard or proposed
        public int Count { get; set; } //number of times it finds something
        public string Title { get; set; } //name of the summary
        public bool PassedAllTests { get; set; }

        public BasicSummary()
        {
            PassedAllTests = true;
        }
    }

    public class BuildingSummary : BasicSummary
    {
        public Area BuildingArea { get; set; }
        public string ID { get; set; } //yet to be used anywhere, have no method for this yet.
        public int NumberOfSpaces { get; set; } //note this is duplicated information
        public int NumberOfStories { get; set; } //note this is duplicated information
    }

    public class SpacesSummary : BasicSummary
    {
        public bool spaceIDs_unique { get;set; }
        //TODO: consider adding total area, or area breakdown by space type.
    }

    public class SurfaceSummary : BasicSummary
    {
        //public double TotalWallSurfaceArea { get; set; }
        //public double TotalRoofSurfaceArea { get; set; }
        //public double TotalSlabOnGradeSurfaceArea { get; set; }
        public int NumberOfInternalWalls { get; set; }
        public int NumberOfExternalWalls { get; set; }
        public int NumberOfUndergroundWalls { get; set; }
        public int NumberOfSlabsOnGrade { get; set; }
        public int NumberOfAirSurfaces { get; set; }
        public int NumberOfRoofs { get; set; }
        public int NumberOfShades { get; set; }
        public int NumberOfInternalFloors_Ceilings { get; set; }
        public bool SurfacesArePlanar { get; set; }

        public SurfaceSummary()
        {
            SurfacesArePlanar = true; //has to be disproven
        }

    }

    public class DetailedSummary
    {
        public string ID { get; set; }
        public bool FoundMatch { get; set; }
        public double TotalSurfaceArea { get; set; }
        public double TotalTestSurfaceArea { get; set; }
        public string AreaUnits { get; set; }
    }

    public class DetailedSurfaceSummary: DetailedSummary
    {
        public List<string> TestSurfaceIDs { get; set; }
        List<DetailedOpeningSummary> Openings { get; set; }

        public DetailedSurfaceSummary()
        {
            Openings = new List<DetailedOpeningSummary>();
            TestSurfaceIDs = new List<string>();
        }
    }

    public class DetailedOpeningSummary : DetailedSummary
    {
        public List<string> TestOpeningIDs { get; set; }

        public DetailedOpeningSummary()
        {
            TestOpeningIDs = new List<string>();
        }
    }

    public class DetailedSpaceSummary : DetailedSummary
    {
        public double TotalVolume { get; set; }
        public double TotalTestVolume { get; set; }
        public string VolumeUnits { get; set; }
    }



    public class CampusReport
    {
        //note if you change these names note they are referenced in the javascript of TestPage.aspx as well.
        public List<DetailedSurfaceSummary> SurfacesReport { get; set; }
        public List<SurfaceSummary> SurfacesSummary { get; set; }
        public List<BuildingSummary> BuildingSummary { get; set; }
        public List<SpacesSummary> SpacesSummary { get; set; }
        public List<DetailedSpaceSummary> SpacesReport { get; set; }
        public int NumberOfBuildings { get; set; }
        public int NumberOfSurfaces { get; set; }
        public CampusReport()
        {
            SurfacesReport = new List<DetailedSurfaceSummary>();
            SurfacesSummary = new List<SurfaceSummary>();
            BuildingSummary = new List<BuildingSummary>();
            SpacesSummary = new List<SpacesSummary>();
            SpacesReport = new List<DetailedSpaceSummary>();
        }
    }

    //this is the "Test Summary"
    public class gbXMLReport
    {
        public string gbxml_version { get; set; }
        public string gbxml_testcase { get; set; }
        public string schema_compliance_results { get; set; }
        public string XMLSchemaWarnings { get; set; }
        public string XMLSchemaErrors { get; set; }
        public string detailed_compliance_results { get; set; } //PASSWARNING/ERROR
        public string message { get; set; }
        public CampusReport CampusReport { get; set; }
        public string menu { get; set; }

        public gbXMLReport()
        {
            detailed_compliance_results = "PASS"; //this has to be disproven, otherwise it assumes the detailed compliance will pass with flying colors.
        }
    }

}
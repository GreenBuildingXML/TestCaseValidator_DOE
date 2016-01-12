using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOEgbXML
{
    public class DOEgbXMLTestCriteriaObject
    {
        public Dictionary<TestType, bool> TestCriteriaDictionary;

       
        public void InitializeTestCriteriaWithTestName(string testname)
        {
            TestCriteriaDictionary = new Dictionary<TestType, bool>();
            
           
            if (testname == "Test1")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add( TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add( TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add( TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test , true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume , true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count , false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count,false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count,false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
            else if (testname == "Test2")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test, true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume, true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, true);          //shades must match
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
            else if (testname == "Test3")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test, true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume, true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
            else if (testname == "Test4")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test, true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume, true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, true);            //shades must match
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
            else if (testname == "Test5")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test, true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume, true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, true);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, true);             //shading surface must match
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
            else if (testname == "Test7")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test, true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume, true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
            else if (testname == "Test8")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test, true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume, true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, true);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
            else if (testname == "Test25")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test, true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume, true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count,false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count,false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
            else if (testname == "Test28")
            {
                DOEgbXMLBasics.SliversAllowed = true;
                TestCriteriaDictionary.Add(TestType.Building_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Count, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_Z_Height, true);
                TestCriteriaDictionary.Add(TestType.Building_Story_PolyLoop_RHR, true);
                TestCriteriaDictionary.Add(TestType.SpaceId_Match_Test, true);
                TestCriteriaDictionary.Add(TestType.Space_Area, true);
                TestCriteriaDictionary.Add(TestType.Space_Volume, true);
                TestCriteriaDictionary.Add(TestType.Total_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Exterior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Underground_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Wall_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Interior_Floor_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Roof_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Shading_Surface_Count, true);           //shading count must match
                TestCriteriaDictionary.Add(TestType.Air_Surface_Count, false);
                TestCriteriaDictionary.Add(TestType.Surface_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Surface_Checks, true);
                TestCriteriaDictionary.Add(TestType.Fixed_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Windows_Count, false);
                TestCriteriaDictionary.Add(TestType.Fixed_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Operable_Skylight_Count, false);
                TestCriteriaDictionary.Add(TestType.Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Non_Sliding_Doors_Count, false);
                TestCriteriaDictionary.Add(TestType.Air_Openings_Count, false);
                TestCriteriaDictionary.Add(TestType.Opening_Planar_Test, true);
                TestCriteriaDictionary.Add(TestType.Detailed_Opening_Checks, true);
                //As of Feb 13 2013, this test is for a future release.  Placeholder only
                TestCriteriaDictionary.Add(TestType.Shell_Geom_RHR, false);
            }
           
        }
    }
}
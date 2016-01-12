using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOEgbXML
{
    public enum TestType
    {
        None,
        Building_Area,
        Space_Count,
        Building_Story_Count,
        Building_Story_Z_Height,
        Building_Story_PolyLoop_RHR,
        SpaceId_Match_Test,
        Space_Area,
        Space_Volume,
        Total_Surface_Count,
        Exterior_Wall_Surface_Count,
        Underground_Surface_Count,
        Interior_Wall_Surface_Count,
        Interior_Floor_Surface_Count,
        Roof_Surface_Count,
        Shading_Surface_Count,
        Air_Surface_Count,
        Surface_Planar_Test,
        Detailed_Surface_Checks,
        Fixed_Windows_Count,
        Operable_Windows_Count,
        Fixed_Skylight_Count,
        Operable_Skylight_Count,
        Sliding_Doors_Count,
        Non_Sliding_Doors_Count,
        Air_Openings_Count,
        Opening_Planar_Test,
        Detailed_Opening_Checks,
        Shell_Geom_RHR
    }
    public class DOEgbXMLenum
    {
    }
}
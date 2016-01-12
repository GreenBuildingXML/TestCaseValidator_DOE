using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace DOEgbXML
{
    public class DOEgbXMLBasics
    {
        public static bool SliversAllowed = true;

        public enum MeasurementUnits
        {
            cubicft,
            sqft,
            ft,
            spaces,
            levels,
        }

        public class Tolerances
        {
            public const double ToleranceDefault = -999;
            public const double VolumeTolerance = 1.0;
            public const double AreaTolerance = 1.0;
            public const double SpaceAreaPercentageTolerance = 0.025;

            //Level (aka - story) height difference tolerance in feet
            public const double LevelHeightTolerance = 0.1;
            public const double VectorAngleTolerance = 2.5;
            public const double SpaceAreaTolerance = 1;
            //all count tolerances
            public const double SpaceCountTolerance = 0;
            public const double LevelCountTolerance = 0;
            public const double SurfaceCountTolerance = 0;
            public const double ExteriorWallCountTolerance = 0;
            public const double InteriorWallCountTolerance = 0;
            public const double InteriorFloorCountTolerance = 0;
            public const double RoofCountTolerance = 0;
            public const double AirWallCountTolerance = 0;
            public const double OpeningCountTolerance = 0;
            public const double FixedWindowCountTolerance = 0;
            public const double OperableWindowCountTolerance = 0;
            public const double FixedSkylightCountTolerance = 0;
            public const double OperableSkylightCountTolerance = 0;
            public const double SlidingDoorCountTolerance = 0;
            public const double NonSlidingDoorCountTolerance = 0;
            public const double AirOpeningCountTolerance = 0;

            //surface tolerances
            public const double SurfaceHeightTolerance = 0.5; //feet
            public const double SurfaceWidthTolerance = 0.5; //feet
            public const double SurfaceTiltTolerance = 2.5; // degrees
            public const double SurfaceAzimuthTolerance = 2.5; //degrees
            public const double SurfaceInsPtXTolerance = 0.5; //feet
            public const double SurfaceInsPtYTolerance = 0.5; //feet
            public const double SurfaceInsPtZTolerance = 0.5; //feet
            public const double SurfacePLCoordTolerance = 0.5; //feet (3 inches)
            public const double SliverDimensionTolerance = 0.25; //feet
            public const double SurfaceAreaPercentageTolerance = 0.025;

            //opening tolerances
            public const double OpeningHeightTolerance = 0.5; //feet
            public const double OpeningWidthTolerance = 0.5; //feet
            public const double OpeningSurfaceInsPtXTolerance = 0.5; //feet
            public const double OpeningSurfaceInsPtYTolerance = 0.5; //feet
            public const double OpeningSurfaceInsPtZTolerance = 0.5; //feet
            public const double OpeningAreaPercentageTolerance = 0.025;
        }

        public class Conversions
        {
            //the idea is, it searches through the document and finds items to switch out
            //it is called when needed by a user or programmer
            public XmlDocument ConvertFtToMeter(XmlDocument origdoc, XmlNamespaceManager gbXMLns1)
            {
                //number of feet in a meter
                double convrate = 3.280839895;

                XmlDocument retdoc = (XmlDocument)origdoc.Clone();
                //by default, I will always change these nodes because they are the minimum that must be presented


                //surface polyloop
                //surface lower left hand corner
                //building storeys
                XmlNodeList nodes = retdoc.SelectNodes("/gbXMLv5:gbXML/gbXMLv5:Campus/gbXMLv5:Building/gbXMLv5:BuildingStorey", gbXMLns1);
                if (nodes.Count > 0)
                {
                    foreach (XmlNode Node in nodes)
                    {
                        XmlNodeList childnodes = Node.ChildNodes;
                        foreach (XmlNode childnode in childnodes)
                        {
                            if (childnode.Name == "Level")
                            {
                                childnode.Value = Convert.ToString(Convert.ToDouble(childnode.Value) / convrate);
                            }
                            else if (childnode.Name == "PlanarGeometry")
                            {
                                //change the planar geometry
                                foreach (XmlNode PolyLoops in childnode)
                                {
                                    //gathers all the cartesian points in a given polyloop
                                    foreach (XmlNode cartesianPoints in PolyLoops)
                                    {
                                        foreach (XmlNode coordinate in cartesianPoints)
                                        {
                                            if (coordinate.Name == "Coordinate")
                                            {
                                                coordinate.Value = Convert.ToString(Convert.ToDouble(coordinate.Value) / convrate);
                                            }
                                            else
                                            {
                                                //this is bad, should terminate somehow
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //space planar geometry
                //space shell geometry
                //space space boundaries
                XmlNodeList spacenodes = retdoc.SelectNodes("/gbXMLv5:gbXML/gbXMLv5:Campus/gbXMLv5:Building/gbXMLv5:Spaces", gbXMLns1);
                if (nodes.Count > 0)
                {
                    foreach (XmlNode Node in nodes)
                    {
                        XmlNodeList childnodes = Node.ChildNodes;
                        foreach (XmlNode childnode in childnodes)
                        {
                            if (childnode.Name == "PlanarGeometry")
                            {
                                //change the planar geometry
                                foreach (XmlNode PolyLoops in childnode)
                                {
                                    //gathers all the cartesian points in a given polyloop
                                    foreach (XmlNode cartesianPoints in PolyLoops)
                                    {
                                        foreach (XmlNode coordinate in cartesianPoints)
                                        {
                                            if (coordinate.Name == "Coordinate")
                                            {
                                                coordinate.Value = Convert.ToString(Convert.ToDouble(coordinate.Value) / convrate);
                                            }
                                            else
                                            {
                                                //this is bad, should terminate somehow
                                            }
                                        }
                                    }
                                }
                            }
                            else if (childnode.Name == "ShellGeometry")
                            {
                                //this should always be the ClosedShell element
                                XmlNode closedShell = childnode.FirstChild;
                                foreach (XmlNode PolyLoops in childnode)
                                {
                                    //gathers all the cartesian points in a given polyloop
                                    foreach (XmlNode cartesianPoints in PolyLoops)
                                    {
                                        foreach (XmlNode coordinate in cartesianPoints)
                                        {
                                            if (coordinate.Name == "Coordinate")
                                            {
                                                coordinate.Value = Convert.ToString(Convert.ToDouble(coordinate.Value) / convrate);
                                            }
                                            else
                                            {
                                                //this is bad, should terminate somehow
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return retdoc;
            }
        }
    }
}
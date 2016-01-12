using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VectorMath;

namespace DOEgbXML
{
    class SurfaceDefinitions
    {
        //creates instances of an object that store information about surfaces in a gbXML file
        public string SurfaceType;
        public string SurfaceId;
        public List<string> AdjSpaceId;
        public double Azimuth;
        public double Tilt;
        public double Height;
        public double Width;
        public Vector.CartCoord InsertionPoint;
        public List<Vector.CartCoord> PlCoords;
        public Vector.CartVect PlRHRVector;
    }
    class SurfaceResults
    {
        public int matchCount;
        public Dictionary<string, List<string>> SurfaceIdMatch;
    }
}
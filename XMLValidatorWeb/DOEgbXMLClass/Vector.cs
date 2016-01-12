using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VectorMath
{
    public class Vector
    {
        public class CartCoord
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }

        public class CartVect
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }

        public static CartVect CreateVector(CartCoord cd1, CartCoord cd2)
        {
            CartVect vector = new CartVect();
            vector.X = cd2.X - cd1.X;
            vector.Y = cd2.Y - cd1.Y;
            vector.Z = cd2.Z - cd1.Z;
            return vector;
        }

        public static Double VectorMagnitude(CartVect vector)
        {
            double magnitude= 0.0;
            
            magnitude = Math.Sqrt(Math.Pow((vector.X),2) + Math.Pow((vector.Y),2) + Math.Pow((vector.Z),2));
            return magnitude;
        }

        public static CartVect UnitVector(CartVect vector)
        {
            CartVect UV = new CartVect();
            double magnitude = VectorMagnitude(vector);

            UV.X = vector.X / magnitude;
            UV.Y = vector.Y / magnitude;
            UV.Z = vector.Z / magnitude;
            return UV;
        }

        public static CartVect CrossProduct(CartVect vector1, CartVect vector2)
        {
            CartVect xProd = new CartVect();

            xProd.X = vector2.Z * vector1.Y - vector1.Z * vector2.Y;
            xProd.Y = vector2.Z * vector1.X - vector1.Z * vector2.X;
            xProd.Z = vector2.Y * vector1.X - vector1.Y * vector2.X;
            return xProd;
        }

        public double getPlanarSA(List<CartVect> polygonVect)
        {
            List<CartVect> normalizedPlane = new List<CartVect>();
            //the new plane's first coordinate is arbitrarily set to zero
            normalizedPlane[0].X = 0;
            normalizedPlane[0].Y = 0;
            normalizedPlane[0].Z = 0;
            double diffX = 0;
            double diffY = 0;
            double diffZ = 0;

            double surfaceArea = -1;
            int numPoints = polygonVect.Count;
            for(int i=0; i<numPoints; i++)
            {
                
                if (i > 0)
                {

                }
            }
            return surfaceArea;
        }
    }
}

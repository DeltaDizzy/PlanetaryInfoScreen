using Kopernicus;
using System.Collections.Generic;
using UnityEngine;

namespace PlanetaryInfoScreen
{
    [RequireConfigType(ConfigType.Node)]
    public class InfoBody : MonoBehaviour
    {
        public List<CelestialBody> infoBodies = new List<CelestialBody>();
        public CelestialBody test;
        public List<CelestialBody> bodies = FlightGlobals.Bodies;

        [ParserTarget("bodyName")]
        public static string bodyName;

        

        public void GetBodies()
        {
            infoBodies.Add(bodies.Find(n => n.name == bodyName));
        }

        public void PrintData()
        {
            foreach (CelestialBody body in infoBodies)
            {
                
            }
        }
    }
}

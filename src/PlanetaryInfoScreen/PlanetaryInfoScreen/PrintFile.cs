using KSP.IO;
using System;
using Kopernicus;
using System.Runtime.InteropServices;
using UnityEngine;
using ModularFI;
using Logger = Kopernicus.Logger;

namespace PlanetaryInfoScreen
{
    public class PrintFile : MonoBehaviour
    {
        //print
        public void Write()
        {
            Logger.Default.SetFilename("Flux.log");

            Logger.Default.Log("Information About Solar Flux");
            //Print solarFlux to log
        }

        void Update()
        {
            if ((Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.V)) && FlightGlobals.ActiveVessel.directSunlight)
            {
                ScreenMessages.PostScreenMessage("Solar Flux for " + FlightGlobals.ActiveVessel.GetCurrentOrbit().referenceBody + "is " + ModularFlightIntegrator.ActiveVesselFI.solarFlux + " Watts/m^2");
            }
            else
            {
                ScreenMessages.PostScreenMessage("You are not in direct Sunlight!  Plase wait until day to measure again.");
            }
        }
    }
}

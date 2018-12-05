using UnityEngine;
using ModularFI;
using Logger = Kopernicus.Logger;
using KSP.Localization;

namespace PlanetaryInfoScreen
{
    public class PrintFile : MonoBehaviour
    {
        public string fluxMsg = "Solar Flux for " + FlightGlobals.ActiveVessel.GetCurrentOrbit().referenceBody + "is " + ModularFlightIntegrator.ActiveVesselFI.solarFlux + " Watts/m^2";
        public string eclipseMsg = "You are not in direct Sunlight!  Plase wait until day to measure again.";
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
                ScreenMessages.PostScreenMessage(Localizer.Format(fluxMsg));
            }
            else
            {
                ScreenMessages.PostScreenMessage(Localizer.Format(eclipseMsg));
            }
        }
    }
}

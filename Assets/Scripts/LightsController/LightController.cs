using System.Threading.Tasks;
using UnityEngine;

public class LightController 
{
    private LightsSet _lightsSet;
    private int _timeDelay = 100;
    private InputManager _inputManager;
        

    public LightController(LightsSet lightsSet, InputManager inputManager )
    {
        _inputManager = inputManager;
        _inputManager.GetDrum += ChooseDrum;
        _lightsSet = lightsSet;
    }


    private void ChooseDrum(Drum drum)
    {
        switch (drum)
        {
            case SnareDrum:
                LightFlash(_lightsSet.SnareDrumLight);
                break;

            case HighHat:
                LightFlash(_lightsSet.HighHatLight);
                break;

            case Crash:
                LightFlash(_lightsSet.CrashLight);
                break;

            case BassDrum:
                LightFlash(_lightsSet.BassDrumLight);
                break;

            case Ride:
                LightFlash(_lightsSet.RideLight);
                break;

            case Tom1:
                LightFlash(_lightsSet.Tom1Light);
                break;

            case Tom2:
                LightFlash(_lightsSet.Tom2Light);
                break;

            case Tom3:
                LightFlash(_lightsSet.Tom3Light);
                break;

            default:
                break;
        }
    }

    private void LightFlash(Light light)
    {
        light.enabled = true;
        TimeDelay(light);
    }

    private async void TimeDelay(Light light)
    {
        await Task.Delay(_timeDelay);
        light.enabled = false;
    }
}

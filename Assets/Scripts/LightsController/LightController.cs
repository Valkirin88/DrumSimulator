using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class LightController 
{
    private LightsSet _lightsSet;
    private RaycastHit _hit;
    private int _timeDelay = 200;

    public LightController(LightsSet lightsSet)
    {
        _lightsSet = lightsSet;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out _hit))
            {
                if (_hit.transform.GetComponent<Drum>())
                {
                    ChooseDrum(_hit.transform.GetComponent<Drum>());
                }

            }
        }
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

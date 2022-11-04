using System.Threading.Tasks;
using UnityEngine;

public class LightController 
{
    private LightsSet _lightsSet;
    private RaycastHit[] _hit;
    private int _timeDelay = 100;
    private DrumController _drumController;

    public LightController(LightsSet lightsSet, DrumController drumController)
    {
        _lightsSet = lightsSet;
        _drumController = drumController;
        _hit = new RaycastHit[5];
    }

    public void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        if (Input.touchCount > 0)
        {
            if (Input.touchCount > 0)
            {
                for (int i = 0; i < Input.touchCount; i++)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Began)
                    {
                        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                        if (Physics.Raycast(ray, out _hit[i]))
                        {
                            if (_hit[i].transform.GetComponent<Drum>())
                            {
                                ChooseDrum(_hit[i].transform.GetComponent<Drum>());
                            }
                        }
                    }
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

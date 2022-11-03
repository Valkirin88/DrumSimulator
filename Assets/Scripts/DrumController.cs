using UnityEngine;

public class DrumController
{
    private RaycastHit _hit;
    private AudioSource _audioSource;
    private DrumsSoundsLibrary _drumsSoundsLibrary;

    public DrumController(DrumsSoundsLibrary drumsSoundsLibrary, AudioSource audioSource)
    {
        _drumsSoundsLibrary = drumsSoundsLibrary;
        _audioSource = audioSource;
    }

    public void Update()
    {
      //  if (Input.GetMouseButtonDown(0))
      if(Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray, out _hit))
                {
                    if (_hit.transform.GetComponent<Drum>())
                    {
                        ChooseDrum(_hit.transform.GetComponent<Drum>());
                    }
                }
            }
        }
    }

    public void ChooseDrum(Drum drum)
    {
            switch (drum)
            {
            case SnareDrum:
                PlaySound(_drumsSoundsLibrary.SnareDrumSound);
                break;

            case HighHat:
                PlaySound(_drumsSoundsLibrary.HighHatSound);
                break;

            case Crash:
                PlaySound(_drumsSoundsLibrary.CrashSound);
                break;

            case BassDrum:
                PlaySound(_drumsSoundsLibrary.BassDrumSound);
                break;

            case Ride:
                PlaySound(_drumsSoundsLibrary.RideSound);
                break;

            case Tom1:
                PlaySound(_drumsSoundsLibrary.Tom1Sound);
                break;

            case Tom2:
                PlaySound(_drumsSoundsLibrary.Tom2Sound);
                break;

            case Tom3:
                PlaySound(_drumsSoundsLibrary.Tom3Sound);
                break;

            default:
                break;
            }
    } 
        
    private void PlaySound(AudioClip audioClip)
    {
        _audioSource.PlayOneShot(audioClip);
    }
}

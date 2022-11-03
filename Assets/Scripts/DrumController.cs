using UnityEngine;


public class DrumController 
{
    private RaycastHit[] _hit;
    private AudioSource _audioSource;
    private DrumsSoundsLibrary _drumsSoundsLibrary;
    private Touch _touch;

      public DrumController(DrumsSoundsLibrary drumsSoundsLibrary, AudioSource audioSource)
    {
        
        _drumsSoundsLibrary = drumsSoundsLibrary;
        _audioSource = audioSource;

#if UNITY_EDITOR
        _hit = new RaycastHit[5];
#endif

//#if UNITY_ANDROID
//        _hit = new RaycastHit[(int)_touch.maximumPossiblePressure];
//#endif

    }

    public void Update()
    {
      //  if (Input.GetMouseButtonDown(0))
      if(Input.touchCount > 0)
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

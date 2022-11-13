using UnityEngine;

public class DrumController 
{
    private AudioSource _audioSource;
    private DrumsSoundsLibrary _drumsSoundsLibrary;
    private InputManager _inputManager;
    

      public DrumController(DrumsSoundsLibrary drumsSoundsLibrary, AudioSource audioSource, InputManager inputManager)
      {
        _inputManager = inputManager;
        _inputManager.GetDrum += ChooseDrum;
        _drumsSoundsLibrary = drumsSoundsLibrary;
        _audioSource = audioSource;
      }

  
    private void ChooseDrum(Drum drum)
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

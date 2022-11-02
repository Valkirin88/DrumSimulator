using UnityEngine;

public class DrumsSoundsLibrary : MonoBehaviour
{
    [SerializeField]
    private AudioClip _snareDrumSound;

    [SerializeField]
    private AudioClip _highHatSound;

    [SerializeField]
    private AudioClip _tom1Sound;

    [SerializeField]
    private AudioClip _tom2Sound;

    [SerializeField]
    private AudioClip _tom3Sound;

    [SerializeField]
    private AudioClip _crashSound;

    [SerializeField]
    private AudioClip _bassDrumSound;

    [SerializeField]
    private AudioClip _rideSound;

    public AudioClip SnareDrumSound => _snareDrumSound;
    public AudioClip HighHatSound => _highHatSound;
    public AudioClip Tom1Sound => _tom1Sound;
    public AudioClip Tom2Sound => _tom2Sound;
    public AudioClip Tom3Sound => _tom3Sound;
    public AudioClip CrashSound => _crashSound;
    public AudioClip BassDrumSound => _bassDrumSound;
    public AudioClip RideSound => _rideSound;
}



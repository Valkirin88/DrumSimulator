using UnityEngine;

public class DrumController 
{
    private RaycastHit _hit;
    private AudioSource _audioSource;
    private DrumsSoundsView _drumsSoundsView;

    public DrumController(DrumsSoundsView drumsSoundsView, AudioSource audioSource)
    {
        _drumsSoundsView = drumsSoundsView;
        _audioSource = audioSource;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out _hit))
            {
                if (_hit.transform.GetComponent<SnareDrum>())
                {
                    _audioSource.PlayOneShot(_drumsSoundsView.SnareDrumSound);
                }

                if (_hit.transform.GetComponent<HighHat>())
                {
                   _audioSource.PlayOneShot(_drumsSoundsView.HighHatSound);
                }

                if (_hit.transform.GetComponent<BassDrum>())
                {
                  _audioSource.PlayOneShot(_drumsSoundsView.BassDrumSound);
                }

                if (_hit.transform.GetComponent<Tom1>())
                {
                    _audioSource.PlayOneShot(_drumsSoundsView.Tom1Sound);
                }

                if (_hit.transform.GetComponent<Tom2>())
                {
                    _audioSource.PlayOneShot(_drumsSoundsView.Tom2Sound);
                }

                if (_hit.transform.GetComponent<Tom3>())
                {
                    _audioSource.PlayOneShot(_drumsSoundsView.Tom3Sound);
                }

                if (_hit.transform.GetComponent<Ride>())
                {
                    _audioSource.PlayOneShot(_drumsSoundsView.RideSound);
                }

                if (_hit.transform.GetComponent<Crash>())
                {
                    _audioSource.PlayOneShot(_drumsSoundsView.CrashSound);
                }

            }
        }
    }

    private void PlaySound(AudioClip audioClip)
    {
        
    }
}

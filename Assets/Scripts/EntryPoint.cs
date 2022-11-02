using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField]
    private DrumsSoundsLibrary _drumsSoundsView;
    [SerializeField]
    private LightsSet _lightsSet;

    private AudioSource _audioSource;
    private DrumController _drumController;
    private LightController _lightController;


    private void Awake()
    {
        _audioSource = _drumsSoundsView.GetComponent<AudioSource>();
        
        _drumController = new DrumController(_drumsSoundsView, _audioSource);

        _lightController = new LightController(_lightsSet);
    }

    private void Update()
    {
        _drumController.Update();
        _lightController.Update();
    }


}

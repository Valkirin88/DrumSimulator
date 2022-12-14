using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField]
    private DrumsSoundsLibrary _drumsSoundsView;
    [SerializeField]
    private LightsSet _lightsSet;

    private InputManager _inputManager;
    private AudioSource _audioSource;
    private DrumController _drumController;
    private LightController _lightController;

    private void Awake()
    {
        _inputManager = new InputManager();

        _audioSource = _drumsSoundsView.GetComponent<AudioSource>();
        
        _drumController = new DrumController(_drumsSoundsView, _audioSource, _inputManager);

        _lightController = new LightController(_lightsSet, _inputManager);
    }

    private void Update()
    {
        _inputManager.Update();
    }


}

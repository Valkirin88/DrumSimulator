using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField]
    private DrumsSoundsLibrary _drumsSoundsView;
    [SerializeField]
    private HitEffectView _hitEffectView;

    private InputManager _inputManager;
    private AudioSource _audioSource;
    private DrumController _drumController;
    private HitEffectManager _hitEffectManager;

    private void Awake()
    {
        _inputManager = new InputManager();

        _audioSource = _drumsSoundsView.GetComponent<AudioSource>();
        
        _drumController = new DrumController(_drumsSoundsView, _audioSource, _inputManager);

        _hitEffectManager = new HitEffectManager(_hitEffectView, _inputManager);
    }

    private void Update()
    {
        _inputManager.Update();
    }


}

using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField]
    private DrumsSoundsView _drumsSoundsView;

    private AudioSource _audioSource;
    private DrumController _drumController;

    private void Awake()
    {
        _audioSource = _drumsSoundsView.GetComponent<AudioSource>();
        
        _drumController = new DrumController(_drumsSoundsView, _audioSource);
    }

    private void Update()
    {
        _drumController.Update();
    }


}

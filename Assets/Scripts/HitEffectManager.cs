using System.Threading.Tasks;
using UnityEngine;

public class HitEffectManager 
{
    private InputManager _inputManager;
    private int _timeDelay = 100;

    [SerializeField]
    private Material _transperentMaterial;
    [SerializeField]
    private Material _lightMaterial;

    public HitEffectManager(InputManager inputManager)
    {
        _inputManager = inputManager;
        _inputManager.GetDrum += ChangeDrumMaterial;
    }

    
    private void ChangeDrumMaterial(Drum drum)
    {
        var material = drum.GetComponent<Renderer>().material;
        material =  _lightMaterial;
        TimeDelay(material);
    }

    private async void TimeDelay(Material material)
    {
        await Task.Delay(_timeDelay);
        material = _transperentMaterial;
    }
}

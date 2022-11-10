using System.Threading.Tasks;
using UnityEngine;

public class HitEffectManager 
{
    private InputManager _inputManager;
    private int _timeDelay = 100;
    private HitEffectView _hitEffectView;
    private Material _material;
   

    public HitEffectManager(HitEffectView hitEffectView, InputManager inputManager)
    {
        _hitEffectView = hitEffectView;
        _inputManager = inputManager;
        _inputManager.GetDrum += ChangeDrumMaterial;
    }

    private void ChangeDrumMaterial(Drum drum)
    {
        _material = drum.GetComponent<MeshRenderer>().material;
        drum.GetComponent<MeshRenderer>().material = _hitEffectView.LightMaterial;
        Debug.Log(drum);
        TimeDelay(drum);
    }

    private async void TimeDelay(Drum drum)
    {
        await Task.Delay(_timeDelay);
        drum.GetComponent<MeshRenderer>().material = _hitEffectView.TransperentMaterial;
    }
}

using UnityEngine;

public class HitEffectManager 
{
    private InputManager _inputManager;
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
        drum.GetComponent<MeshRenderer>().material = _hitEffectView.LightMaterial;
        _hitEffectView.TimeDelay(drum);
    } 
}

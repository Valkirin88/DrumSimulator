using UnityEngine;

public class HitEffectView: MonoBehaviour
{
    [SerializeField]
    private Material _transperentMaterial;
    [SerializeField]
    private Material _lightMaterial;

    public Material TransperentMaterial => _transperentMaterial; 
    public Material LightMaterial  => _lightMaterial; 
}

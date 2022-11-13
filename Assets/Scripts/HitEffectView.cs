using System.Collections;
using UnityEngine;

public class HitEffectView: MonoBehaviour
{
    [SerializeField]
    private Material _transperentMaterial;
    [SerializeField]
    private Material _lightMaterial;

    private float _timeDelay = 0.1f;

    public Material TransperentMaterial => _transperentMaterial; 
    public Material LightMaterial  => _lightMaterial;

    public void TimeDelay(Drum drum)
    {
        StartCoroutine(TimeDelayC(drum));
    }

    public IEnumerator TimeDelayC(Drum drum)
    {
        yield return new WaitForSeconds(_timeDelay);
        drum.GetComponent<MeshRenderer>().material = TransperentMaterial;
    }
}

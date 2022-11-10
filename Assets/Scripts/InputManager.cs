using System;
using UnityEngine;

public class InputManager
{
    public Action<Drum> GetDrum;

    private RaycastHit[] _hit;
    private Drum _drum;
    private Touch _touch;

    public InputManager()
    {

#if UNITY_EDITOR
        _hit = new RaycastHit[5];
#endif


#if UNITY_ANDROID
        _hit = new RaycastHit[(int)_touch.maximumPossiblePressure];
#endif

    }

    //public void Update()
    //{
    //    if (Input.touchCount > 0)
    //    {
    //        for (int i = 0; i < Input.touchCount; i++)
    //        {
    //            if (Input.GetTouch(i).phase == TouchPhase.Began)
    //            {
    //                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
    //                if (Physics.Raycast(ray, out _hit[i]))
    //                {
    //                    _drum = _hit[i].transform.GetComponent<Drum>();

    //                    if (_drum)
    //                    {
    //                        GetDrum?.Invoke(_drum);
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out _hit[0]))
                    {
                        _drum = _hit[0].transform.GetComponent<Drum>();

                        if (_drum)
                        {
                            GetDrum?.Invoke(_drum);
                        }
                    }
                
           }
        }
    }
}

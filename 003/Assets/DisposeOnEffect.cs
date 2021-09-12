using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DisposeOnEffect : MonoBehaviour
{
    [SerializeField] 
    private GameObject effect;
    private bool _iseffectNotNull;

    // Start is called before the first frame update
    void Start()
    {
        _iseffectNotNull = effect != null;
    }

    private void OnControllerColliderHit(ControllerColliderHit other)
    {
        Debug.Log(other.gameObject.name);

        if(other.gameObject.name == "Cube")
        {
            StartCoroutine(EffectActibate());
        }
    }
    IEnumerator EffectActibate()
    {
        if (_iseffectNotNull)
        {
            var instantiate = Instantiate(effect, transform) as GameObject;
            Destroy(instantiate, 1);
        }
        return null;
    }
}

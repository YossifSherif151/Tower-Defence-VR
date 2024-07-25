using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Collider _bulletcollider;

    private void Start()
    {
        _bulletcollider = GetComponent<Collider>();
        _bulletcollider.enabled = false;
        StartCoroutine(activatecollider());
    }

    IEnumerator activatecollider()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            _bulletcollider.enabled=true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemyshhoting : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _shootingpoint;
    [SerializeField] private Rigidbody _bulletrb;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shooting());
    }

   IEnumerator shooting()
    {
         GameObject newBullet = Instantiate(_bullet, _shootingpoint);
        _bulletrb.AddForce(newBullet.transform.forward * 60);
        yield return new WaitForSeconds(0.2f);
    }
}

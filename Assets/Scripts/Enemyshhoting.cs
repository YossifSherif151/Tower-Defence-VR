using System.Collections;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _shootingpoint;
  

    void Start()
    {
        StartCoroutine(Shooting());
    }

    IEnumerator Shooting()
    {
        while (true)
        {
            GameObject newBullet = Instantiate(_bullet, _shootingpoint.transform.position, Quaternion.identity);

            
            Rigidbody bulletRb = newBullet.GetComponent<Rigidbody>();

            if (bulletRb != null)
            {
                
                bulletRb.AddForce(_shootingpoint.transform.forward * 60, ForceMode.Impulse);
            }

            
            yield return new WaitForSeconds(3f);
        }
    }
}

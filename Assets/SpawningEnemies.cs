using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _target;
    private float _xpos;
    private float _zpos;
    private int _enemycount;
    void Start()
    {
        StartCoroutine(spawneenemy());
    }

    IEnumerator spawneenemy()
    {
        while (_enemycount < 10)
        {
            _xpos=Random.Range(-4.36f,-3.01f);
            _zpos=Random.Range(-3.84f,3.96f);
            GameObject newEnemy = Instantiate(_enemy, new Vector3(_xpos, -0.3f, _zpos), Quaternion.identity);
            newEnemy.transform.LookAt(_target.transform);
            yield return new WaitForSeconds(1.5f);
            _enemycount +=1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceSelection : MonoBehaviour
{
    [SerializeField] List<GameObject> forces;
    public GameObject selectedForce;

    private void Start()
    {
        selectedForce = forces[0];
    }
    public void SetForceToButton(int ForceIndex)
    {
        selectedForce = forces[ForceIndex];
    }
}

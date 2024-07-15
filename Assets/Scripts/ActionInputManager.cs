using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ActionInputManager : MonoBehaviour
{
    [SerializeField] private InputActionProperty _aim_action;
    [SerializeField] private Animator _handanimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _triggervalue = _aim_action.action.ReadValue<float>();
        _handanimator.SetFloat("Grip", _triggervalue);
    }
}

using System;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent OnSpacePressed = new UnityEvent();
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }
    }
}

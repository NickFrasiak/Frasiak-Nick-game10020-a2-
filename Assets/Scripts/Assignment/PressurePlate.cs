using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent OnTogglePressurePlate;

    private bool isPressurePlateDown = false;

    private void Start()
    {
        if (OnTogglePressurePlate == null)
        {
            OnTogglePressurePlate = new UnityEvent();
        }
    }

    public void TogglePressurePlate()
    {
        isPressurePlateDown = !isPressurePlateDown;
        OnTogglePressurePlate.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Weight"))
        {
            TogglePressurePlate();
        }
    }
    
}

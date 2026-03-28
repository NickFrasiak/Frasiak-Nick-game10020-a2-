using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Flashlight : MonoBehaviour
{
    public LayerMask lockLayerMask;

    [HideInInspector] public UnityEvent OnLockLit;

    private float lightTimer = 0.0f;
    private bool canLightBeUsed = true;
    

    private void Start()
    {
        if (OnLockLit == null)
        {
            OnLockLit = new UnityEvent();
        }
    }
    
    private void Update()
    {
        if (!canLightBeUsed)
        {
            if (lightTimer >= 0.75f)
            {
                lightTimer = 0;
                canLightBeUsed = true;
            }
            lightTimer += Time.deltaTime;
            return;
        }
        
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, 7.0f, lockLayerMask))
        {
            OnLockLit.Invoke();
            canLightBeUsed = false;
        }
    }
    
    
}

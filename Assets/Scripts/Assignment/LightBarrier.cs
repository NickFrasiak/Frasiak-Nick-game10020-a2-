using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightBarrier : MonoBehaviour
{
    
    [HideInInspector]
    public UnityEvent OnBarrierToggle;

    private bool isBarrierDown = false;

    private Vector3 startPosition;
    private Vector3 endPosition;
    
    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(transform.position.x, -2, transform.position.z);
        
        
        if (OnBarrierToggle == null)
        {
            OnBarrierToggle = new UnityEvent();
        }
    }

    void Update()
    {
        if (isBarrierDown)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, endPosition, 0.5f);
        }
        else
        {
            transform.position = Vector3.MoveTowards(this.transform.position, startPosition, 0.5f);
        }
    }

    public void ToggleBarrier()
    {
        isBarrierDown = !isBarrierDown;
    }
    
    
    
}

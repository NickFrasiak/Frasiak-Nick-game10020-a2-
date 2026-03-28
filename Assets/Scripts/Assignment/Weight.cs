using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour, IPushable
{
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    public void Push(GameObject otherGameObject)
    {
        rb.AddForce((transform.position - otherGameObject.transform.position).normalized * 10.0f, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("character"))
        {
            Push(other.gameObject);
        }
    }
}

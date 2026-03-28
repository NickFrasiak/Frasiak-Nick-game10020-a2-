using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightDoor : MonoBehaviour
{
    private bool isDoorLocked = true;
    public Material doorMaterial;


    // Update is called once per frame
    void Update()
    {
        if (isDoorLocked)
        {
            doorMaterial.color = Color.red;
        }
        else
        {
            doorMaterial.color = Color.green;
        }
    }

    public void ToggleState()
    {
        isDoorLocked = !isDoorLocked;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("character") && !isDoorLocked)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}

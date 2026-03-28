using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LightBarrier lightBarrier;
    public PressurePlate pressurePlate;
    public Weight weight;
    public Flashlight flashlight;
    public Character character;
    public LightDoor door;

    private void Start()
    {
        flashlight.OnLockLit.AddListener(lightBarrier.ToggleBarrier);
        pressurePlate.OnTogglePressurePlate.AddListener(door.ToggleState);
    }
}

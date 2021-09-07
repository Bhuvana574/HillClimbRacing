using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelRefill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        CarMovement.carinstance.fuel = 1.0f;
        Destroy(gameObject);
        
    }
}

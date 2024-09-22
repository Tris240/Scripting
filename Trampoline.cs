using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trampoline : MonoBehaviour
{
    // Method that triggers when the player enters the trampoline area
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Access the Jump component on the player and set the jump strength to 10
            Jump playerJump = other.GetComponent<Jump>();
            if (playerJump != null)
            {
                playerJump.jumpStrength = 10f; // Increase jump strength
            }
        }
    }

    // Method that triggers when the player exits the trampoline area
    private void OnTriggerExit(Collider other)
    {
        // Check if the object exiting the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Access the Jump component on the player and reset the jump strength to 2
            Jump playerJump = other.GetComponent<Jump>();
            if (playerJump != null)
            {
                playerJump.jumpStrength = 2f; // Reset jump strength
            }
        }
    }
}
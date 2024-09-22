

using UnityEngine;
using UnityEngine.SceneManagement; // Use SceneManagement for runtime

public class SceneChange : MonoBehaviour
{
    public string sceneName; // Field to store the scene name

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the colliding object is tagged as Player
        {
            SceneManager.LoadScene(sceneName); // Load the specified scene
        }
    }
 }
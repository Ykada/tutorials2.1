using UnityEngine;
using System.Collections;

public class Elf : EnemyParent
{
    private float visibilityToggleInterval = 3f; // Toggle visibility every 3 seconds
    private float visibilityDuration = 0.5f; // Stay invisible for 0.5 seconds
    private Renderer rend;

    void Start()
    {
        // Elf has low health but moves fast
        health = 1;
        moveSpeed = 5f;
        rend = GetComponent<Renderer>();

        Initialize();
        Debug.Log("Elf spawned with low health (" + health + ") and fast speed (" + moveSpeed + ")");

        // Start the visibility toggle coroutine
        StartCoroutine(ToggleVisibility());
    }

    private IEnumerator ToggleVisibility()
    {
        while (health > 0)
        {
            // Wait for the toggle interval
            yield return new WaitForSeconds(visibilityToggleInterval);

            // Go invisible
            if (rend != null)
            {
                rend.enabled = false;
                Debug.Log("Elf is now invisible");
            }

            // Stay invisible for the duration
            yield return new WaitForSeconds(visibilityDuration);

            // Become visible again
            if (rend != null)
            {
                rend.enabled = true;
                Debug.Log("Elf is now visible again");
            }
        }
    }
}

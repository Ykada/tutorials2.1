using UnityEngine;

public class Brute : EnemyParent
{
    void Start()
    {
        // Brute has more health and moves slower
        health = 3;
        moveSpeed = 0.5f;

        Initialize();
        Debug.Log("Brute spawned with high health (" + health + ") and slow speed (" + moveSpeed + ")");
    }
}

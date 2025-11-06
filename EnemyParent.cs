using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float moveSpeed = 2f;
    public int health = 1;
    private float moveDirection = 1f; // 1 = right, -1 = left
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        Initialize();
    }

    void Update()
    {
        if (health > 0)
        {
            Move();
        }
    }

    protected void Initialize()
    {
        Debug.Log("Enemy initialized with health: " + health + " and speed: " + moveSpeed);
    }

    protected void Move()
    {
        transform.position += Vector3.right * moveDirection * moveSpeed * Time.deltaTime;
    }

    // Called when the enemy is hit by a projectile
    public void TakeDamage(int damage = 1)
    {
        health -= damage;
        Debug.Log("Enemy hit! Health remaining: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }
}

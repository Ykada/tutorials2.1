using UnityEngine.UIElements;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    [SerializeField] private float _speed = 9;
    [SerializeField] private float _range = 15;
    [SerializeField] private float _distance = 5;
    internal float speed => _speed;

    internal virtual void TakeDamage(int damage)
    {
        health -= damage;
    }
    internal virtual float CalculateRange(float modifier)
    {
        return _range;
    }
    internal int health = 100;
}

public class ennemy : BaseEnemy
{
    internal void Attack()
    {
        // Attack logic
    }
    GameObject player;
    internal void Update()
    {
        //if (distance(gameObject.transform, position, player.transform.position) > CalculateRange(speed / 5))
        //{
        //    Attack();
        //}
    }
    internal void OnTriggerEnter(Collision other)
    {
        //if (other.CompareTag("Trap"))
        //{
        //    TakeDamage(50);
        //}
    }
    float attackRange = 2f;
}

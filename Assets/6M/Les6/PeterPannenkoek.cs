using UnityEngine;

public class PeterPannenkoek : MonoBehaviour
{
    protected float health = 100f;
    protected float speed = 2f;

    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"{gameObject.name} dondert TIRING HARD van de trap en pakt {damage} damage HP: {health}");
        if (health <= 0)
        {
            Die();
        }
    }

    public virtual void Attack(GameObject target)
    {
        Debug.Log($"{gameObject.name} valt aan!");
    }

    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} ging naar jefrey epstines eiland en mocht niet weg");
        Destroy(gameObject);
    }
}

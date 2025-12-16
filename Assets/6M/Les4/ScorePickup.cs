using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    public int scoreValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(scoreValue);
            }

            Destroy(gameObject);
        }
    }
}

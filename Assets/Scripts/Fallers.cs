using UnityEngine;

public class Fallers : MonoBehaviour
{
    public int scoreValue = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger hit: " + other.tag);

        if (other.CompareTag("catch"))
        {
            ScoreManager.Instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
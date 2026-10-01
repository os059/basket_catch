using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered trigger with: " + other.gameObject.name);
        ScoreManager.Instance.AddScore(1);
    }
}
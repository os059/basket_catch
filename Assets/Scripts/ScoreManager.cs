using UnityEngine;
using UnityEngine.Assemblies;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int currentScore = 0;

    void Start()
    {
        public void AddScore(int amount)
    {
        currentScore = +amount;
    }
}

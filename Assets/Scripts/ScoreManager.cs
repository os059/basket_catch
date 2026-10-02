using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int currentScore = 0;

    [SerializeField] private TextMeshProUGUI scoretext;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        UpdateUI();
    }
    public void AddScore(int amount)
    {
        currentScore += amount;
        Debug.Log("Score:" + currentScore);
        UpdateUI();
    }
    public void ResetScore()
    {
        currentScore = 0;
        UpdateUI();
    }
    public int GetScore()
    {
        return currentScore;
    }
    private void UpdateUI()
    {
        if (scoretext != null)
        {
            scoretext.text = "Score:" + currentScore;
        }
    }
}


 


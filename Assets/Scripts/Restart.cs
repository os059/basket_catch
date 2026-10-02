using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public void ResetEverything()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.ResetScore();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
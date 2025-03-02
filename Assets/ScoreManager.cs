using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public static ScoreManager scoreManager;
    public int score = 0;
    void Start()
    {
        scoreManager = this;

    }

  public void increaseScore(int increase){
        score += increase;
        scoreText.text = $"Score: {score}";
   }
}

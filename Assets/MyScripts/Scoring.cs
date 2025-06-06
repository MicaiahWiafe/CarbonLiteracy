using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    [Header("Scoring Settings")]
    [SerializeField] private int startingScore;               // Set initial score
    private int currentScore;

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI scoreText;           // Drag your TMP Text here
    [SerializeField] private Color initialTextColor = Color.white; // Set poor score color
    [SerializeField] private Color midwayTextColor = Color.white;  // Set decent score color
    [SerializeField] private Color successTextColor = Color.white; // Set good score color

    private void Start()
    {
        currentScore = startingScore;
        UpdateScoreText();
        scoreText.color = initialTextColor;
        Debug.Log("ScoreText reference is: " + (scoreText != null ? "OK" : "NULL"));
        DontDestroyOnLoad(gameObject);
    }

    private void Awake()
    {
        if (scoreText == null)
        {
            scoreText = GameObject.Find("ScoreText")?.GetComponent<TextMeshProUGUI>();
            Debug.LogWarning("ScoreText not assigned in Inspector — trying to find by name.");
        }

       
    }


    public void IncreaseScore(int amount)
    {
        currentScore += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)
    {
        currentScore -= amount;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = currentScore.ToString();
    }

    public void setMidwayTextColor()
    {
        scoreText.color = midwayTextColor;
    }

    public void setSuccessTextColor(){
        scoreText.color = successTextColor;
    }
}

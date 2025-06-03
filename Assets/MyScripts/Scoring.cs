using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    [Header("Scoring Settings")]
    [SerializeField] private int startingScore = 0;               // Set initial score
    private int currentScore;

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI scoreText;           // Drag your TMP Text here
    [SerializeField] private Color initialTextColor = Color.white; // Set initial text color
    [SerializeField] private Color midwayTextColor = Color.white;
    [SerializeField] private Color successTextColor = Color.white;

    private void Start()
    {
        currentScore = startingScore;
        UpdateScoreText();
        scoreText.color = initialTextColor;
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

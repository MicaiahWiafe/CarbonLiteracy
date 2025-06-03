using UnityEngine;
using TMPro;

public class TMPColorChanger : MonoBehaviour
{
    [Header("Assign in Inspector")]
    public TextMeshProUGUI targetText; // The TMP text to change
    public Color chosenColor = Color.white; // Color picked in the Inspector

    // This function will be called by the button
    public void ChangeTextColor()
    {
        if (targetText != null)
        {
            targetText.color = chosenColor;
        }
    }
}

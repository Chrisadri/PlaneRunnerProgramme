using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreDisplay : MonoBehaviour
{
    public static float bestScore;

    public TextMeshProUGUI bestScoreText;

    private void Update()
    {
        bestScoreText.text = "Best Score: " + bestScore; //shows at title saying Best Score (from the string then plus the actual score counted)
    }
}

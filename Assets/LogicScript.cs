using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("IncreaseScore")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}

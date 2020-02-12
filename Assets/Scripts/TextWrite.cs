using UnityEngine;
using UnityEngine.UI;

public class TextWrite : MonoBehaviour
{
    public Text scoreText;
    public Transform thePlayer;

    void Update()
    {
        scoreText.text = thePlayer.position.z.ToString("0");
    }
}



using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float gap = 81f;
    public float score;
    void Update()
    {
        score = player.position.z + 81;
        scoreText.text = score.ToString("0") ;
    }
}

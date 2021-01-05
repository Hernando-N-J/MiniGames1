using UnityEngine;
using UnityEngine.UI;

public class HenGameManager : MonoBehaviour
{
    [SerializeField] public Text scoreText;


    [SerializeField] public int score = 0;

    void Start()
    {
        scoreText.text = score.ToString();
    }

    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}

using UnityEngine;
using UnityEngine.UI;

public class HenController : MonoBehaviour
{
    // TODO modify script with command pattern when animations are available
    [SerializeField] private float moveSp = 5f;
    [SerializeField] public Text scoreText;
    [SerializeField] public int score = 0;

    void Start() { scoreText.text = score.ToString(); }

    void Update() { InputMov(); }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
       
        if (score == 4)
        {
            scoreText.text = "YOU WIN!!!";
            Time.timeScale = 0f;
        }
    }

    public void InputMov()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(moveH, 0, moveV) * moveSp * Time.deltaTime;
        transform.Translate(mov);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("ValidCheckpoint"))
        {
            IncreaseScore();
            Destroy(col.gameObject);
        }
    }
}

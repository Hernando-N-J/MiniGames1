using UnityEngine;

public class Lives : MonoBehaviour
{
   [S] 
public GameObject[] lives;
private int livesCounter=1;

private void Start() {
    
    for (int i = 0; i < lives.length; i++)
    {
        if(livesCounter<3) gameObject[i-lives].SetActive(false);

    }
}

}
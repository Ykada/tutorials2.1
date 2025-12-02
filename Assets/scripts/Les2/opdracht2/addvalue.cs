using UnityEngine;
using UnityEngine.UI;

public class addvalue : MonoBehaviour
{
    [SerializeField] private Text value;

    private int score = 0;
    public void AddValue()
    {
        score++;
        Debug.Log("Score: " + score);
        value.text = score.ToString();
    }

}

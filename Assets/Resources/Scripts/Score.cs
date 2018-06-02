using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    private int score;
    static GUIStyle style;

    // Use this for initialization
    void Start()
    {
        score = 0;

        style = new GUIStyle("label");
        style.fontSize = 20;
        GUI.color = Color.black;
    }

    void OnGUI()
    {
        string s_string = "SCORE: " + score.ToString();
        GUI.Label(new Rect(Screen.width - 200, 10, 200, 40), s_string, style);
    }

    public void reset()
    {
        score = 0;
    }

    public void addScore(int i)
    {
        score += i;
    }

    public int getScore()
    {
        return score;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript red;
    public GoalScript blue;
    public GoalScript orange;
    public GoalScript green;

    
    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (red.IsSolved() && blue.IsSolved() && orange.IsSolved() && green.IsSolved())
        {
            isGameOver = true;
        }
    }

    void OnGUI()
    {
        if (isGameOver)
        {
            
            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75), "GameOver");
            GUI.Box(new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50), "GameOver");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int Scor = 0;
    void OnGUI()
    {
        GUI.Label(new Rect(1, 1, 100, 50), "Score: " + Scor);
    }
}

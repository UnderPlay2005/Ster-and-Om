using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusScore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Player");
    }


    // Update is called once per frame
    public void AddScore()
    {
        Player.GetComponent<Score>().Scor += 10;
    }
}

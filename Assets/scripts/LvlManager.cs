using UnityEngine;
using System.Collections;

public class LvlManager : MonoBehaviour {

    private int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(score);
	}
    public void AddPoints(int Points)
    {
        score += Points;  
    }

    void onGUI()
    {
        GUILayout.Label(score.ToString());
    }
}

using UnityEngine;
using System.Collections;

public class lives : MonoBehaviour
{
    public GameObject prefab;
    public float NumberOfLives;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {

       
        if (coll.gameObject.tag == "missile")
        {

            GameObject obj = Instantiate(prefab, coll.transform.position, Quaternion.identity) as GameObject;
            Destroy(coll.gameObject);
            NumberOfLives--;
            Debug.Log(NumberOfLives);
            if(NumberOfLives == 0)
                Application.LoadLevel(2);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50, 25, 100, 30), "Health: " + NumberOfLives.ToString());
    }
}

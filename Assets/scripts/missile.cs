using UnityEngine;
using System.Collections;

public class missile : MonoBehaviour
{

    private float speed;
    public GameObject prefab;
    private GameObject obj;
    public int scoreValue;
    
    
    

    void Start()
    {
        speed = 1f;
        
        
       

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        position = new Vector2(position.x, position.y - speed * Time.deltaTime);
        transform.position = position;

        
       
    }
    void OnCollisionEnter2D(Collision2D coll)
    {

       
        if (coll.gameObject.tag == "explosion")
        {
            
            GameObject obj = Instantiate(prefab, this.transform.position, Quaternion.identity) as GameObject;
            ScoreManager.score += scoreValue;
            Destroy(gameObject);
        }
        
    }
}
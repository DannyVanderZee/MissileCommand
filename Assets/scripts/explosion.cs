using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour
{

    public GameObject prefab;
    private GameObject obj;
    
    

    void start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject obj = Instantiate(prefab, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane)), Quaternion.identity) as GameObject;
                
            }
        
        
    }
}

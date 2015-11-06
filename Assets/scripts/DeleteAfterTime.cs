using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class DeleteAfterTime : MonoBehaviour {
    private float delay = 0.5f;
    
    
    void Awake()
    {
        
        Destroy(gameObject, delay);
           
    }
  
}

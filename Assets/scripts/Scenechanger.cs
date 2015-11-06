using UnityEngine;
using System.Collections;

public class Scenechanger : MonoBehaviour {

    public int SceneNumber;
	
	
	// Update is called once per frame
	public void loadLevel (int level) {
        
            Application.LoadLevel(level);
        
          
   
    }
}

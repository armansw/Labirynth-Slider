using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public Transform CurrentPlayerPosition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
	    savePosition();
	}
    }

    public void savePosition(){
		
	Transform CurrentPlayerPosition = this.gameObject.transform;
		
	PlayerPrefs.SetFloat("PosX", CurrentPlayerPosition.position.x);
	PlayerPrefs.SetFloat("PosY", CurrentPlayerPosition.position.y);
	PlayerPrefs.SetFloat("PosZ",CurrentPlayerPosition.position.z); 
		
	PlayerPrefs.SetFloat("AngX", CurrentPlayerPosition.eulerAngles.x); 
	PlayerPrefs.SetFloat("AngY", CurrentPlayerPosition.eulerAngles.y);
	
	PlayerPrefs.SetString("level", Application.loadedLevelName); 
	PlayerPrefs.SetInt("level_id", Application.loadedLevel); 
    }
}

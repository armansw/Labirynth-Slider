using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int playerHealth;
     
    [SerializeField] private Text healthText;
    [SerializeField] private GameObject restartUI;
	
    [SerializeField] private PlayerController myPlayerControllerScript; 
    [SerializeField] private string myLevel;

    private void Start(){
	UpdateHealth();
	restartUI.SetActive(false);
    }

    public void UpdateHealth(){
	healthText.text = playerHealth.ToString("0");
	if (playerHealth <= 0){
	    myPlayerControllerScript.enabled = false;
	    restartUI.SetActive(true);
	}
    }

    public void RestartButton(){
	SceneManager.LoadScene(myLevel);
	restartUI.SetActive(false);
    }    

}

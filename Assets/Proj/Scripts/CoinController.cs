using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour
{
    [SerializeField] private PlayerController myPlayerController;
    [SerializeField] private Text coinText;
    [SerializeField] private string nextLevel;
    [SerializeField] private GameObject congratsUI;
        
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
	coinText.text = coins.ToString("0");
	congratsUI.SetActive(false);
    }

    public void UpdateCoins(){
	coins--;
	coinText.text = coins.ToString("0");
	if (coins == 0 && nextLevel != "Level1"){
	    SceneManager.LoadScene(nextLevel);
        }
	else if(coins == 0 && nextLevel == "Level1"){
	    myPlayerController.enabled = false;
	    congratsUI.SetActive(true);
	}
    }

    public void StartButton(){
	SceneManager.LoadScene(nextLevel);
	congratsUI.SetActive(false);
    }
    
}

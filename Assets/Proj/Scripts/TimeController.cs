using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{

    [SerializeField] private int levelPassSeconds;
    [SerializeField] private PlayerController myPlayerController;
    [SerializeField] private GameObject restartUI;
    [SerializeField] private Text secondsText;
    private int currCountdownValue;

    private IEnumerator StartCountdown(){
	currCountdownValue = levelPassSeconds;
	while (currCountdownValue >= 0){
	    secondsText.text = currCountdownValue.ToString("0");
     	    yield return new WaitForSeconds(1);
	    currCountdownValue--;
	}
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        if(currCountdownValue <= 0) {
	    myPlayerController.enabled = false;
	    restartUI.SetActive(true);
	}
    }
}

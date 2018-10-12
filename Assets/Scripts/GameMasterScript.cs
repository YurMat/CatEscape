using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMasterScript : MonoBehaviour {

    GameObject hpGauge;

	// Use this for initialization
	void Start () {
        this.hpGauge = GameObject.FindWithTag("hpGauge");
        Debug.Log("Find hpGauge");
		
	}
	
	// Update is called once per frame
	public void DecreaseHp () {
        Debug.Log(" start DecreaseHP");
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        Debug.Log(" DecreaseHP");
	}
}

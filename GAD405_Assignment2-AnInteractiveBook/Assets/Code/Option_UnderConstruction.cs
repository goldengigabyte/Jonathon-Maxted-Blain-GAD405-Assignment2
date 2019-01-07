using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_UnderConstruction : MonoBehaviour {
	public GameObject Pan;
	public void Oof(){
		Pan.SetActive(true);
		var mine = FindObjectOfType<Start_onPress>();
		mine.Message.text="oops, the <Options> button is sadly under construction, \nthe error bots are working hard, or are they hardly working...";
	}
}

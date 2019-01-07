using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program_Speech : MonoBehaviour {
	public void Intro(){
		var use = FindObjectOfType<Start_onPress>();
		use.Message.text="eh? \nthis... isnt right...\ni shouldn\'t be seeing you, i\'m the Error reporter";
	}
}

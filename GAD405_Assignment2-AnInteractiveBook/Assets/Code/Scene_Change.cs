using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour {
	public string Scene_Select;
	
	void oop(){
		var Num = FindObjectOfType<Start_onPress>();
		var Call = Num.Call_Num;
		if(Call == 0){
			Scene_Select = "scene2";
		}else if (Call == 1){
			Scene_Select = "scene3";
		}else if (Call >= 2){
			Scene_Select = "scene4";
		}
	}
	public void NEXT(){
		var Num = FindObjectOfType<Start_onPress>();
		oop();
		SceneManager.LoadScene(Scene_Select);
		Num.Call_Num++;
	}
}

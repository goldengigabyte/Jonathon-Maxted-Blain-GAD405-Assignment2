using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_onPress : MonoBehaviour {
	public GameObject Open_Menu;
	public GameObject UI_KeepAlive;
	public Text Message;
	public Text Score_Out;
	public string Next_Scene;
	public int Call_Num;

	public void Awake(){
		UI_KeepAlive.gameObject.SetActive(false);
		Next_Scene = "scene1";
		Call_Num = 0;
	}
	private void FixedUpdate(){
		Score_Out.text = "NaN40404";
	}
	public void Start_Game(){
        SceneManager.LoadScene(Next_Scene);
        Open_Menu.SetActive(false);
		UI_KeepAlive.SetActive(true);
    }
}

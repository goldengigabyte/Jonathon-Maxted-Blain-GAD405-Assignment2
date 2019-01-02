using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_onPress : MonoBehaviour {
	public GameObject Open_Menu;
	public GameObject UI_KeepAlive;
	public Text Message;
	private string Score;
	public Text Score_Out;
	public string Next_Scene;

	public void Awake(){
		UI_KeepAlive.gameObject.SetActive(false);
		DontDestroyOnLoad(UI_KeepAlive);
		Score = "NaN40404";
	}
	private void FixedUpdate(){
		Score_Out.text = Score;
	}
	public void Start_Game(){
        SceneManager.LoadScene(Next_Scene);
        Open_Menu.SetActive(false);
		UI_KeepAlive.SetActive(true);
    }
}

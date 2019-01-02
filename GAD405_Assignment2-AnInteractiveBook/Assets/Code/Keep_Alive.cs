using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Keep_Alive : MonoBehaviour {
	public void Awake(){
		DontDestroyOnLoad(gameObject);
	}
}

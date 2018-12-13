using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Adventure_Game : MonoBehaviour {
    public Image Banana;
    public Image Key;
    public int Coins;
    public Text Coins_Show;
    public string Next_Scene;
    public GameObject Panel;
    public Text ur_a_mess;

    private void Awake(){
        Banana.gameObject.SetActive(false);
        Key.gameObject.SetActive(false);
        DontDestroyOnLoad(gameObject);
        ur_a_mess.text = "";

    }
    private void FixedUpdate(){
        Coins_Show.text = Coins.ToString();
    }
    public void Start_Game()
    {
        SceneManager.LoadScene(Next_Scene);
        Panel.SetActive(false);
    }
}

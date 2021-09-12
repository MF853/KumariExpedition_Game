using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    //public GameObject nomeAvo;
    //public GameObject nomeKumari;
   //public string sceneIndex;

    void Awake() {
        continueButton.SetActive(false);
        /*nomeAvo.SetActive(false);
        nomeKumari.SetActive(false);
        sceneIndex = SceneManager.GetActiveScene().name;*/
     }
    void Start(){
        StartCoroutine(Type());
    }

    void Update() {
            if(textDisplay.text == sentences[index]){
            continueButton.SetActive(true);
            //NameConditions();
        }
    }


    IEnumerator Type(){
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void NextSentence(){

        continueButton.SetActive(false);

        if (index < sentences.Length -1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    /*void NameConditions(){
        if(sceneIndex == "Introducao"){
                if(index == 3){
                    nomeKumari.SetActive(true);
                }
                if(index == 4){
                    nomeAvo.SetActive(true);
                }
                else{
                    nomeKumari.SetActive(false);
                    nomeAvo.SetActive(false);
                }
            }
    }*/
}

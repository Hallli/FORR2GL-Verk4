using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ByrjaScript : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void QuitGame(){
        Debug.Log("Leikurinn er lokaður"); // skrifa þetta
        Application.Quit();
    }
}

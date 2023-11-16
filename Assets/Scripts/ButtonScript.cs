using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void HomeSceneloader(){
        SceneManager.LoadScene(0);
    }


    public void ARSceneloader(){

        SceneManager.LoadScene(1);
}
    public void Loader(){
        SceneManager.LoadScene("Menu");
}
    
    public void QuitApp(){ 
        Application.Quit();

}
    
}

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

        SceneManager.LoadScene("FurAdd");
}
    public void Loader(){
        SceneManager.LoadScene("Home");
}
    public void ProductPage()
    {
        SceneManager.LoadScene("UrunSayfa");
    }
    

    public void QuitApp(){ 
        Application.Quit();

}
    
}

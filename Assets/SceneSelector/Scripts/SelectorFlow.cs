
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorFlow : MonoBehaviour
{
    //==================================================================================================================
    // Button
    //==================================================================================================================
    
    //Sends you to the Zen Garden Game 
    public void GoToZen()
    {
        SceneManager.LoadScene("Scene_1");
    }

    //Sends you to the Pachinko Game 
    public void GoToPan()
    {
        SceneManager.LoadScene("Scene_2");
    }
    
    //Sends you to the Credits 
    public void GoToCredits()
    {
        SceneManager.LoadScene($"Credits");
    }
    
    
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    //==================================================================================================================
    // Exit Button
    //==================================================================================================================
    public void GoToScene()
    {
        SceneManager.LoadScene($"Scene_Selector");
    }
}

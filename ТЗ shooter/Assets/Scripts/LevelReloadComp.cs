using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReloadComp : MonoBehaviour
{
    public void LVL_Reload()
    {
        var scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReloadComp : MonoBehaviour
{
    //перезагружает активную сцену (тоже на все случаи жизни)
    
    public void LVL_Reload()
    {
        var scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadNextLevel", 5f);
    }

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}

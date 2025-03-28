using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SceneButtonLoaderByIndex : MonoBehaviour
{
    [SerializeField] private int sceneIndex;

    private void Awake()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(() => LoadSceneByIndex());
    }

    public void LoadSceneByIndex()
    {
        if (sceneIndex >= 0 && sceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogWarning("Scene index " + sceneIndex + " is out of range.");
        }
    }
}

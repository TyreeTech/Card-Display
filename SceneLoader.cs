using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public TMP_Dropdown sceneDropdown; // Use TMP_Dropdown for TextMeshPro Dropdown.

    public void StartGame()
    {
        int selectedSceneIndex = sceneDropdown.value;
        string selectedSceneName = sceneDropdown.options[selectedSceneIndex].text;

        // Use StartCoroutine to start a coroutine for asynchronous loading.
        StartCoroutine(LoadSceneAsync(selectedSceneName));
    }

    private System.Collections.IEnumerator LoadSceneAsync(string sceneName)
    {
        // Create an asynchronous operation to load the scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the asynchronous operation is complete.
        while (!asyncLoad.isDone)
        {
            // You can perform tasks while the scene is loading, such as updating a progress bar.
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f); // 0.9 is used as a completion threshold.
            Debug.Log("Loading progress: " + (progress * 100) + "%");

            yield return null; // Yielding here allows the while loop to continue in the next frame.
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackScene()
    {
      StartCoroutine(LoadSceneAsync("Title Page"));
    }
}

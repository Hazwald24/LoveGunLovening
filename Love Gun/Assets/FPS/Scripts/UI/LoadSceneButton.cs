using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class LoadSceneButton : MonoBehaviour
{
    public string sceneName = "";

    private void Update()
    {
        if(EventSystem.current.currentSelectedGameObject == gameObject
            && Input.GetButtonDown(GameConstants.k_ButtonNameSubmit))
        {
            LoadTargetScene();
        }
    }

    public void LoadTargetScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PlayAgainButton()
    {
       AnalyticsResult analyticsResult = Analytics.CustomEvent("PlayAgain");
        Debug.Log("Analytics Result: " + analyticsResult);

        SceneManager.LoadScene(sceneName);
    }

    public void PlayButton()
    {
        AnalyticsResult analyticsResult = Analytics.CustomEvent("Time in menu", new Vector3(0, Time.timeSinceLevelLoad, 0));
        Debug.Log("Analytics Result: " + analyticsResult);

        SceneManager.LoadScene(sceneName);
    }
}

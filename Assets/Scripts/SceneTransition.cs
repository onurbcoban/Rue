using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public Image fadePanel;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(FadeAndLoadScene("GameScreen"));
        }
    }
    IEnumerator FadeAndLoadScene(string sceneName)
    {
        float duration = 0.5f;
        float time = 0;
        Color color = fadePanel.color;

        while(time < duration)
        {
            time += Time.deltaTime;
            color.a = Mathf.Lerp(0, 1, time/duration);
            fadePanel.color = color;
            yield return null;
        }

        SceneManager.LoadScene(sceneName);

    }
}

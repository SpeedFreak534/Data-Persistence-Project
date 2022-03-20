using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] GameObject InputField;
    public TextMeshProUGUI BestScoreText;

    private void Start()
    {
        BestScoreText.text = "Best Score: " + SavedData.playerBestName + ": " + SavedData.playerBestScore;
    }

    public void StartNew()
    {
        SavedData.playerName = InputField.GetComponent<TMP_InputField>().text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}

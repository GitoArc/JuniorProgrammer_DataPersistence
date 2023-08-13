using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public static NameManager Instance;
    public string CurrentName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void SetName(InputField textComp)
    {
        CurrentName = textComp.text;
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("main");
    }
}

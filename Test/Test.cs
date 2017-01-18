using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour {
    public InputField inputField = null;
    void Start()
    {
        inputField = transform.GetComponentInChildren<InputField>();
    }
    public void OnAddManager()
    {
        ScheduleManager.Schedule(delegate { });
    }

    public void OnChargeScene()
    {
        string name = inputField.text;
        SceneManager.LoadScene(name);
    }
}

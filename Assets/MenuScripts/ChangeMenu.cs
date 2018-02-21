using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMenu : MonoBehaviour
{
    public string SceneToGoName = "";
    public void Start()
    {
        Debug.Log(this.transform.parent.name);
        if (string.IsNullOrEmpty(SceneToGoName))
        {
            SceneToGoName = this.transform.parent.name;
        }
    }
    public void OnMouseClick()
    {

        SceneManager.LoadScene(SceneToGoName);
    }
}

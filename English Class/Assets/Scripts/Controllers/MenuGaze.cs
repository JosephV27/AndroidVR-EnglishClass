using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuGaze : MonoBehaviour
{

    // Variables for distance from camera and menu

    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 3.5f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;

    private bool gaze = false;
    private Vector3 _startingPosition;


    public void OnPointerMenuQEnter()
    {
     
        gaze = true;
        Debug.Log("Tocamos menu..............");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
			Application.Quit();
        #endif
    }

    public void OnPointerMenuLearnButtonEnter()
    {
        SceneManager.LoadScene(1);
        
    }

    public void OnPointerExit()
    {
        gaze = false;
        Debug.Log("Dejamos de tocar menu");
    }

    public void OnPointerMenuLearnButtonExit()
    {
        gaze = false;
        Debug.Log("Dejamos de tocar menu");
    }

    public void OnPointerMenuQExit()
    {
        gaze = false;
        Debug.Log("Dejamos de tocar menu");
    }

}

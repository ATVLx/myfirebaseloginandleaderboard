using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {
    private void Awake()
    {
        StartCoroutine(changesceneinintro());
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator changesceneinintro(){
        yield return new WaitForSecondsRealtime(16f);
        SceneManager.LoadScene("Login");
    }
}

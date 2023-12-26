using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
     public string newScene;
    // Start is called before the first frame update
   public void Start()
    {
        
    }
    public void onButtonClick(){
         Debug.Log("Hi");
        SceneManager.LoadScene(newScene);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

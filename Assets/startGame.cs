using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        if (Input.mousePresent)
        {
            SceneManager.LoadScene("level1");
        }
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}

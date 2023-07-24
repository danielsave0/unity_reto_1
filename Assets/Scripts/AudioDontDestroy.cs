using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioDontDestroy : MonoBehaviour
{
    public GameObject musik;
    public int var;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(musik);
        
        
        

        
        if (GameObject.FindGameObjectsWithTag(musik.name).Length==2)
        {
            Destroy(musik);

        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}

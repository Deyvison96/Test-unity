using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs : MonoBehaviour
{
    public float position;
    
    // Start is called before the first frame update
    void Start()
    {
        position = UnityEngine.PlayerPrefs.GetFloat("POSITION", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndGoal : MonoBehaviour
{
    public TextMeshProUGUI winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
        winText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
        }
    }
}

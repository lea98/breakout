using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesControllerScript : MonoBehaviour
{
    public GameObject heart;
    private int livesCounter = 3;
    List<GameObject> livesobject = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < livesCounter; i++) {
            GameObject newObject = Instantiate(heart, new Vector3(transform.position.x+i,transform.position.y, transform.position.z) , Quaternion.identity);
            livesobject.Add(newObject);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReduceLife()
    {
        livesCounter--;
        Destroy(livesobject[livesCounter]);

    }
}

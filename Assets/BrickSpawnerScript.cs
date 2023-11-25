using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawnerScript : MonoBehaviour
{
    public GameObject brick;
    private Color[] brickColor = { Color.blue, Color.red, Color.cyan, Color.gray, Color.yellow, Color.green, Color.white, Color.magenta };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 7; i++) {
            brick.GetComponent<SpriteRenderer>().color = brickColor[i];
            for (int j = 0; j <= 10; j++) {
                Instantiate(brick, new Vector3(-7.85f + j * 1.58f, 4.67f - i * 0.53f, 0), Quaternion.identity);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

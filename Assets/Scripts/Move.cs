using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public int speed;
    public int score;
    public Text scoreText;
    void Update()
    {
        //move on x //normalise movement //A D or arrow keys 1 -1//this is how fast we move
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Fruit"))
        {
            FruitHandler fruit = col.gameObject.GetComponent<FruitHandler>();
            score += fruit.fruitPoints;
            Destroy(col.gameObject);
            scoreText.text = "Score: "+score;
        }
    }
}

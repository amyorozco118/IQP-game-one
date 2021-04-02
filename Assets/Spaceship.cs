
using UnityEngine;
using System.Collections;
//Baseclase 
public class Spaceship : MonoBehaviour
{
    /*
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    */
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Square")
        {
            Score.SubtractPoint();

        }
    }


}

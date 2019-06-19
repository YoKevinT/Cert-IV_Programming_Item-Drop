using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FruitHandler : MonoBehaviour
{
    public int fruitPoints;
    void Start()
    {
        //destry this fruit 2 seconds after spawning
        Destroy(this.gameObject, 2.0f);
    }
}

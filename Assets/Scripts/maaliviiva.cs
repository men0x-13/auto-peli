 using UnityEngine;

public class maaliviiva : MonoBehaviour
{
    private void OnTriggerEnter(Collider auto)
    {
        var id = auto.GetComponent<CarIdentity>();
        Debug.Log("Winner is" + id.car_name)
    }

}

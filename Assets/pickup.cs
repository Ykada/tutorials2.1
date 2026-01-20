using UnityEngine;

public class pickup : Collectable
{
    public int value = 1;

    public override void OnCollect()
    {
        Debug.Log("Picked up coin worth: " + value);
        Destroy(gameObject);
    }
}
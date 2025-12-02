using UnityEngine;

public class onclick : MonoBehaviour
{
    addvalue script;
    private void Start()
    {
        Debug.Log("Start");
        script = GameObject.Find("Canvas").GetComponent<addvalue>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            script.AddValue();
        }
    }
}
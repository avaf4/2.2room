using UnityEngine;

public class overhead_lights : MonoBehaviour
{
    [SerializeField] Light bulb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // turn lamp on
        if (bulb.enabled == false){
            if (Input.GetKeyDown(KeyCode.A))
            {
                //turn lamp on
                    bulb.enabled = true;
            }
        }
        else if (bulb.enabled == true){
            if (Input.GetKeyDown(KeyCode.A))
            {
                //turn lamp on
                    bulb.enabled = false;
            }
        }
    }
}

using UnityEngine;

public class floor_lights : MonoBehaviour
{
    [SerializeField] Light bulb;
    [SerializeField] Material ShadeOn;
    [SerializeField] Material ShadeOff;
    [SerializeField] Renderer Shade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // turn lamp on
        if (bulb.enabled == false){
            if (Input.GetKeyDown(KeyCode.S))
            {
                //turn lamp on
                    bulb.enabled = true;
                // set shade's material to ShadeOn
                    Shade.material = ShadeOn;
            }
        }
        else if (bulb.enabled == true){
            if (Input.GetKeyDown(KeyCode.S))
            {
                //turn lamp on
                    bulb.enabled = false;
                // set shade's material to ShadeOn
                    Shade.material = ShadeOff;
            }
        }
    }
}

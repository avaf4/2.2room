using UnityEngine;

public class overhead_lights : MonoBehaviour
{
    [SerializeField] Light bulb;
    [SerializeField] Material LightOn;
    [SerializeField] Material LightOff;
    [SerializeField] Renderer GlassBulb1, GlassBulb2, GlassBulb3, GlassBulb4, GlassBulb5, GlassBulb6, GlassBulb7, GlassBulb8;

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
                // set shade's material to LightOn
                    GlassBulb1.material = LightOn;
                    GlassBulb2.material = LightOn;
                    GlassBulb3.material = LightOn;
                    GlassBulb4.material = LightOn;
                    GlassBulb5.material = LightOn;
                    GlassBulb6.material = LightOn;
                    GlassBulb7.material = LightOn;
                    GlassBulb8.material = LightOn;
            }
        }
        else if (bulb.enabled == true){
            if (Input.GetKeyDown(KeyCode.A))
            {
                //turn lamp on
                    bulb.enabled = false;
                // set shade's material to LightOff
                    GlassBulb1.material = LightOff;
                    GlassBulb2.material = LightOff;
                    GlassBulb3.material = LightOff;
                    GlassBulb4.material = LightOff;
                    GlassBulb5.material = LightOff;
                    GlassBulb6.material = LightOff;
                    GlassBulb7.material = LightOff;
                    GlassBulb8.material = LightOff;
            }
        }
    }
}

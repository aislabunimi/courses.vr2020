using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupScene : MonoBehaviour
{
    public RotateAndOrbit mercuryGO;
    public RotateAndOrbit venusGO;
    public RotateAndOrbit earthGO;
    public RotateAndOrbit marsGO;
    public RotateAndOrbit jupiterGO;
    public RotateAndOrbit saturnGO;
    public RotateAndOrbit uranusGO;
    public RotateAndOrbit neptuneGO;

        
    private Mercury _mercury;

    private Venus _venus;

    private Earth _earth;

    private Mars _mars;

    private Jupiter _jupiter;

    private Saturn _saturn;

    private Uranus _uranus;

    private Neptune _neptune;

    private AUConversionHelper _conversionHelper;

    private const float scale = 1E-10f;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        _mercury = new Mercury();
        _venus = new Venus();
        _earth = new Earth();
        _mars = new Mars();
        _jupiter = new Jupiter();
        _saturn = new Saturn();
        _uranus = new Uranus();
        _neptune = new Neptune();
        _conversionHelper = new AUConversionHelper();
        ActivateRotation();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateRotation()
    {
        mercuryGO.startMovement(_conversionHelper.ConvertPositionToSI((_mercury.initialPosition)) * scale,_mercury.rotationRate, _mercury.scale);
 
    }


    
}

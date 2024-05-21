using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBullets : MonoBehaviour
{
    public FireWeaponComponent FireWeaponComponent;
    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
 
        Text.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (FireWeaponComponent != null)
        {
            int remainingBullets = FireWeaponComponent.RemainingBullets; 
            int clipSize = FireWeaponComponent.WeaponDefinition.ClipSize;
            Text.text = $"{remainingBullets}/{clipSize}";
        }
    }
}

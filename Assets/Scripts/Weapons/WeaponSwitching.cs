using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public InputManager inputManager;
    //Gibt an wieviele Waffen es in dem aktiven Spiel gibt
    private int weaponCount;
    private int currentWeaphon = 0;
    private void Awake()
    {
        //geht in denn 'WeaponHolder' und schaut wie viele child objekts er hat und sagt so viele waffen gibt es
        foreach (Transform weaponModel in transform)
        {
            weaponCount++;
        }
    }
    public void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weaponModel in transform)
        {
            if (i == currentWeaphon)
            {
                weaponModel.gameObject.SetActive(true);
                inputManager.weapon = weaponModel.GetComponent<Weapon>();//the same but not working so not really <--inputManager.gun = weaphonArray[currentWeaphon].GetComponent<Gun>();-->
            }
            else
            {
                weaponModel.gameObject.SetActive(false);
            }
            i++;
        }
    }
    public void GunSwitchUp()
    {
        if (currentWeaphon < weaponCount - 1)
        {
            currentWeaphon++;
            SelectWeapon();
        }
    }
    public void GunSwitchDown()
    {
        if (currentWeaphon > 0)
        {
            currentWeaphon--;
            SelectWeapon();
        }
    }
}


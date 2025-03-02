
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Weapon : MonoBehaviour
{
/*

    //gun Stats
    [Header("Gun Stats")]
    public int damage;
    public int magazineSize;
    public int bulletsPerClick;
    public int curentAmmo;
    //public int bulletsShot;
    public bool canRapidFire;
    public float timeBetweenShootingPerClick;
    public float spread;
    public float range = 9000000;
    public float reloadTime;
    public float timeBetweenRapiedFire;
    //bools
    bool redayToShoot;
    bool isReloading;
    //reference
    public Camera fpsCam;
    //public Transform attackPoint;
    public RaycastHit rayHit;
    //public LayerMask whatIsEnemy;
    //ammo Text
    [SerializeField] private TextMeshProUGUI ammoText;
    //Animations
    [Header("Animations")]
    public Animator animator;


    private void Awake()
    {
        curentAmmo = magazineSize;
        redayToShoot = true;

    }
    private void Update()
    {
        ammoText.text = curentAmmo + "/" + magazineSize;
    }
    public void Shoot()
    {
        //schaut ob der spamm click couldown schon durch is und l�st dann wieder schie�en
        if (redayToShoot)
        {
            redayToShoot = false;
            for (int i = 0; i < bulletsPerClick; i++)
            {



                //wenn man WASD macht oder Space dann mach var spread += 1.5f oder so else .... 
                

                //Spreed
                float x = Random.Range(-spread, spread);
                float y = Random.Range(-spread, spread);
                //Calculate Direction with Spread
                Vector3 direction = fpsCam.transform.forward + new Vector3(x, y, 0);
                //RayCast
                //schaut ob er ein OBJ(GameObject) hited 
                if (Physics.Raycast(fpsCam.transform.position, direction, out rayHit, range))
                {
                    //schaut ob man dem OBJ Schaden machen kann
                    if (rayHit.collider.GetComponent<Damageable>() != null)
                    {
                        //macht schaden und gibt die position f�r die hit animation an
                        rayHit.collider.GetComponent<Damageable>().TakeDamage(damage, rayHit.point, rayHit.normal);
                    }
                }
                //reduziert deine Buletts
                curentAmmo--;

            }
            //Macht 'ResetShot()' nach der 'timeBetweenShooting' Zeit
            Invoke("ResetShot", timeBetweenShootingPerClick);
        }
    }
    public IEnumerator RapidFire()
    {

        if (CanShoot() == true)
        {
            //Schie�t dann schaut er ob dauerfeuer bei der waffe an ist
            Shoot();
            if (canRapidFire)
            {
                //wenn ja wartet der die FeuerRate ab und schie�t dann noch mal in einer schleife
                while ((CanShoot() == true))
                {
                    yield return 0;
                    Shoot();
                }
            }
        }
        //Wenn man nicht schie�en kann aber auch nicht reloadet 
        else if ((CanShoot() == false) && (isReloading == false))
        {
            //started Reload()
            Reload();
        }
    }
    public void ResetShot()
    {
        redayToShoot = true;
    }
    public void Reload()
    {
        if (curentAmmo == magazineSize)
        {
            return;
        }
        else
        {
            isReloading = true;
            animator.SetBool("isReloading", true);
            Invoke("ReloadFinshed", reloadTime);
        }
    }
    private void ReloadFinshed()
    {
        curentAmmo = magazineSize;
        animator.SetBool("isReloading", false);
        isReloading = false;
    }
    bool CanShoot()
    {
        bool canShoot = false;
        if ((curentAmmo > 0) && (isReloading == false))
        {
            canShoot = true;

        }
        return canShoot;
    }



    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public bool canshoot = true; 
    public GameObject bullet;
	public List<Bullet> projectiles;
	public int maxProjectiles = 200;


	void Start()
	{
		for (int i = 0; i < maxProjectiles; i++)
		{
			projectiles.Add(Instantiate(bullet).GetComponent<Bullet>());
			projectiles[i].gameObject.SetActive(false);
			projectiles[i].name = bullet.name + "_" + i;
		}
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKey("f") == true)
        {
            if (canshoot == true)
            {
                canshoot = false;

				Bullet newBullet = projectiles[0];

				newBullet.transform.position = transform.position;
				newBullet.gameObject.SetActive(true);

				newBullet.transform.rotation = Quaternion.LookRotation(transform.forward, transform.up);

				newBullet.initialize();
				projectiles.Add(newBullet);
				projectiles.RemoveAt(0);

				StartCoroutine("Example");
            }
        }
	}

    IEnumerator Example()
    {

        yield return new WaitForSeconds(.1f);
        canshoot = true;
    }
}

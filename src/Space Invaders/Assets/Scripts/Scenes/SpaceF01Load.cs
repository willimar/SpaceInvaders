using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceF01Load : MonoBehaviour
{
    public GameObject satelite = null;

    Quaternion cameraStartRotation = new Quaternion(0f, 180f, 0f, 0);
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(39f, 0, -1133);
        this.gameObject.transform.rotation = cameraStartRotation;
        this.satelite.transform.position = new Vector3(43f, 0f, -1165f);

        var toRemove = new List<Transform>()
        {
            satelite.transform.Find("solar_plane1"),
            satelite.transform.Find("turret_1")?.transform.Find("Body_1"),
            satelite.transform.Find("turret_1")?.transform.Find("Temperature_1"),
            satelite.transform.Find("turret_2")?.transform.Find("Body_2"),
            satelite.transform.Find("turret_2")?.transform.Find("Temperature_2")
        };

        foreach (var item in toRemove)
        {
            if (item != null)
            {
                Destroy(item.gameObject);
            }
        }

        satelite.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.y > 0f)
        {
            transform.Rotate(new Vector3(0, 359f, 0), 1);

            var speedX = satelite.transform.position.x > 34 ? 0.1f : satelite.transform.position.z < -1127 ? 0.05f : 0;
            var speedZ = satelite.transform.position.z < -1132 ? 0.5f : satelite.transform.position.z < -1127 ? 0.1f : 0;

            var x = satelite.transform.position.x - speedX;
            var z = satelite.transform.position.z + speedZ;
            var y = satelite.transform.position.y;

            satelite.transform.SetPositionAndRotation(new Vector3(x, y, z), satelite.transform.rotation);
        }
        else if (satelite.transform.position.x < transform.position.x)
        {
            var speedX = 0.1f;

            var x = satelite.transform.position.x + speedX;
            var z = satelite.transform.position.z;
            var y = satelite.transform.position.y;

            satelite.transform.SetPositionAndRotation(new Vector3(x, y, z), satelite.transform.rotation);
        }
        else if (satelite.transform.position.z > transform.position.z)
        {
            var speedZ = -0.1f;

            var x = satelite.transform.position.x;
            var z = satelite.transform.position.z + speedZ;
            var y = satelite.transform.position.y;

            satelite.transform.SetPositionAndRotation(new Vector3(x, y, z), satelite.transform.rotation);
        }
    }
}

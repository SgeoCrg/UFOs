using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    [SerializeField] float velocidad = 2;
	[SerializeField] Transform prefabDisparo;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * velocidad * Time.deltaTime, 0, 0);
		
		if (Input.GetButtonDown("Fire1"))
		{
			Instantiate(prefabDisparo, transform.position, Quaternion.identity);
		}
    }
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
	Debug.Log("BUMKRAKEN");
	}
}

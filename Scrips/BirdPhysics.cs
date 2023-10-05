using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2;
    public float force = 200;
    int puntuacio = 0;
    [SerializeField]
    TextMeshProUGUI textpuntuacio;
    [SerializeField]
    TextMeshProUGUI Temps;
    private float tempsTranscorregut = 0f;
    int vida = 3;
    [SerializeField]
    TextMeshProUGUI vidas;
    private int puntsbarrera;
    [SerializeField]
    TextMeshProUGUI barrerapunts;
    void Start()
    {
        Rigidbody2D birdBody = GetComponent<Rigidbody2D>();
        birdBody.velocity = Vector2.right * speed;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D birdBody = GetComponent<Rigidbody2D>();
            birdBody.AddForce(Vector2.up * force);
        }
        tempsTranscorregut += Time.deltaTime;
        Temps.text = Mathf.FloorToInt(tempsTranscorregut).ToString();

       

    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.CompareTag("Pickup"))
        {
            puntuacio++;
            textpuntuacio.text = puntuacio.ToString();
            Destroy(colision.gameObject);
        }
        else if (colision.gameObject.CompareTag("Enemy"))
        {
            vida = vida - 1;
            vidas.text = vida.ToString();

            
            if (vida <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        Rigidbody2D birdBody = GetComponent<Rigidbody2D>();

        if (colision.CompareTag("Barrera") && transform.position.y > birdBody.transform.position.y) 
        {
            
            puntsbarrera++;
            barrerapunts.text = puntsbarrera.ToString();
        }

    }




    private void OnCollisionEnter2D(Collision2D colision)
        {

        
        

           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


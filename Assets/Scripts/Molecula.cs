using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecula : MonoBehaviour
{
    public GameObject[] atomos;

    public GameObject molecula;


    private Vector3 distancia;
    private Vector3 distancia2;
    private Vector3 distancia3;
    private Vector3 distancia4;

    public bool taPerto=false;

    private int distantiaMin=70;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(atomos.Length==2)
        {
            //checar distancias
            distancia = new Vector3(atomos[0].transform.position.x - atomos[1].transform.position.x,
                            atomos[0].transform.position.y - atomos[1].transform.position.y,
                            atomos[0].transform.position.z - atomos[1].transform.position.z);
        
            //quando tiver perto
            if(distancia.x <= distantiaMin && distancia.x >= -distantiaMin &&
                distancia.z <= distantiaMin && distancia.z >= -distantiaMin)
            {
                if(!taPerto)
                {  
                    molecula.SetActive(true);
                    atomos[0].SetActive(false);
                    atomos[1].SetActive(false);
                    taPerto=true;
                }
            }
            //quando separar
            else
            {
                if(taPerto)
                {     
                    molecula.SetActive(false);
                    atomos[0].SetActive(true);
                    atomos[1].SetActive(true);
                    taPerto=false;
                }
            }        
        }
        else if (atomos.Length==3)
        {
            //checar distancias
            distancia = new Vector3(atomos[0].transform.position.x - atomos[1].transform.position.x,
                                    atomos[0].transform.position.y - atomos[1].transform.position.y,
                                    atomos[0].transform.position.z - atomos[1].transform.position.z);

            distancia2 = new Vector3(atomos[0].transform.position.x - atomos[2].transform.position.x,
                                    atomos[0].transform.position.y - atomos[2].transform.position.y,
                                    atomos[0].transform.position.z - atomos[2].transform.position.z);
                                    
            //quando tiver perto
            if(distancia.x <= distantiaMin && distancia.x >= -distantiaMin &&
                distancia.z <= distantiaMin && distancia.z >= -distantiaMin &&
                distancia2.x <= distantiaMin && distancia2.x >= -distantiaMin &&
                distancia2.z <= distantiaMin && distancia2.z >= -distantiaMin)
            {
                if(!taPerto)
                {  
                    molecula.SetActive(true);
                    atomos[0].SetActive(false);
                    atomos[1].SetActive(false);
                    atomos[2].SetActive(false);
                    taPerto=true;
                }
            }
            //quando separar
            else
            {
                if(taPerto)
                {  
                    molecula.SetActive(false);
                    atomos[0].SetActive(true);
                    atomos[1].SetActive(true);
                    atomos[2].SetActive(true);
                    taPerto=false;
                }
            }
        }
        else if (atomos.Length==4)
        {
             //checar distancias
            distancia = new Vector3(atomos[0].transform.position.x - atomos[1].transform.position.x,
                                    atomos[0].transform.position.y - atomos[1].transform.position.y,
                                    atomos[0].transform.position.z - atomos[1].transform.position.z);

            distancia2 = new Vector3(atomos[0].transform.position.x - atomos[2].transform.position.x,
                                    atomos[0].transform.position.y - atomos[2].transform.position.y,
                                    atomos[0].transform.position.z - atomos[2].transform.position.z);

            distancia3 = new Vector3(atomos[0].transform.position.x - atomos[3].transform.position.x,
                                    atomos[0].transform.position.y - atomos[3].transform.position.y,
                                    atomos[0].transform.position.z - atomos[3].transform.position.z);
                                    
            //quando tiver perto
            if(distancia.x <= distantiaMin && distancia.x >= -distantiaMin &&
                distancia.z <= distantiaMin && distancia.z >= -distantiaMin &&
                distancia2.x <= distantiaMin && distancia2.x >= -distantiaMin &&
                distancia2.z <= distantiaMin && distancia2.z >= -distantiaMin &&
                distancia3.x <= distantiaMin && distancia3.x >= -distantiaMin &&
                distancia3.z <= distantiaMin && distancia3.z >= -distantiaMin)
            {
                if(!taPerto)
                {  
                    molecula.SetActive(true);
                    atomos[0].SetActive(false);
                    atomos[1].SetActive(false);
                    atomos[2].SetActive(false);
                    atomos[3].SetActive(false);
                    taPerto=true;
                }
            }
            //quando separar
            else
            {
                if(taPerto)
                {  
                    molecula.SetActive(false);
                    atomos[0].SetActive(true);
                    atomos[1].SetActive(true);
                    atomos[2].SetActive(true);
                    atomos[3].SetActive(true);
                    taPerto=false;
                }
            }
        }
         else if (atomos.Length==5)
        {
             //checar distancias
            distancia = new Vector3(atomos[0].transform.position.x - atomos[1].transform.position.x,
                                    atomos[0].transform.position.y - atomos[1].transform.position.y,
                                    atomos[0].transform.position.z - atomos[1].transform.position.z);

            distancia2 = new Vector3(atomos[0].transform.position.x - atomos[2].transform.position.x,
                                    atomos[0].transform.position.y - atomos[2].transform.position.y,
                                    atomos[0].transform.position.z - atomos[2].transform.position.z);

            distancia3 = new Vector3(atomos[0].transform.position.x - atomos[3].transform.position.x,
                                    atomos[0].transform.position.y - atomos[3].transform.position.y,
                                    atomos[0].transform.position.z - atomos[3].transform.position.z);
            
            distancia4 = new Vector3(atomos[0].transform.position.x - atomos[4].transform.position.x,
                                    atomos[0].transform.position.y - atomos[4].transform.position.y,
                                    atomos[0].transform.position.z - atomos[4].transform.position.z);
                                    
            //quando tiver perto
            if(distancia.x <= distantiaMin && distancia.x >= -distantiaMin &&
                distancia.z <= distantiaMin && distancia.z >= -distantiaMin &&
                distancia2.x <= distantiaMin && distancia2.x >= -distantiaMin &&
                distancia2.z <= distantiaMin && distancia2.z >= -distantiaMin &&
                distancia3.x <= distantiaMin && distancia3.x >= -distantiaMin &&
                distancia3.z <= distantiaMin && distancia3.z >= -distantiaMin &&
                distancia4.x <= distantiaMin && distancia4.x >= -distantiaMin &&
                distancia4.z <= distantiaMin && distancia4.z >= -distantiaMin)
            {
                if(!taPerto)
                {  
                    molecula.SetActive(true);
                    atomos[0].SetActive(false);
                    atomos[1].SetActive(false);
                    atomos[2].SetActive(false);
                    atomos[3].SetActive(false);
                    atomos[4].SetActive(false);
                    taPerto=true;
                }
            }
            //quando separar
            else
            {
                if(taPerto)
                {  
                    molecula.SetActive(false);
                    atomos[0].SetActive(true);
                    atomos[1].SetActive(true);
                    atomos[2].SetActive(true);
                    atomos[3].SetActive(true);
                    atomos[4].SetActive(true);
                    taPerto=false;
                }
            }
        }
    }

    
}

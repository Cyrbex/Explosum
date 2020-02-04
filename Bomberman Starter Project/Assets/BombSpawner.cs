using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;

public class BombSpawner : MonoBehaviour
{
    public Tilemap tilemap;

    public GameObject bombPrefab;

    public GameObject player;
   
    public float cooldown1 = 3f;
    public float cooldown2 = 3f;
    public float cooldown3 = 3f;
    public float cooldown4 = 3f;

    public int firepower1 = 1; //firepower is gained from FireBoost pickups which increases the explosion range and is told to BombExplode script as "keissi".
    public int firepower2 = 1;
    public int firepower3 = 1;
    public int firepower4 = 1;

    public int bombcount1 = 1;
    public int bombcount2 = 1;
    public int bombcount3 = 1;
    public int bombcount4 = 1;

    public bool isKeyPressed = false;

    void Update()
    {
        cooldown1 += Time.deltaTime;
        cooldown2 += Time.deltaTime;
        cooldown3 += Time.deltaTime;
        cooldown4 += Time.deltaTime;

        //Player1 spawning bomb(s) to its position. firepower tells the explosion range and bombcount how many can be laid "at the same time".

        if (gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.RightControl) && cooldown1 >= 3)
        {
            Vector3 worldPos1 = player.transform.position;
            Vector3Int cell1 = tilemap.WorldToCell(worldPos1);
            Vector3 cellCenterPos1 = tilemap.GetCellCenterWorld(cell1);

            Instantiate(bombPrefab, cellCenterPos1, Quaternion.identity);

            FindObjectOfType<BombExplode>().keissi = firepower1;

            isKeyPressed = true;
            cooldown1 = 0;
        }

        if (gameObject.tag == "Player" && bombcount1 >= 2 && Input.GetKeyUp(KeyCode.RightControl))
        {

            Vector3 worldPos1 = player.transform.position;
            Vector3Int cell1 = tilemap.WorldToCell(worldPos1);
            Vector3 cellCenterPos1 = tilemap.GetCellCenterWorld(cell1);

            Instantiate(bombPrefab, cellCenterPos1, Quaternion.identity);
            FindObjectOfType<BombExplode>().keissi = firepower1;

            bombcount1--;
            Invoke("AddBomb", 1);
        }

        //Player2

        if (gameObject.tag == "Player2" && Input.GetKeyDown(KeyCode.KeypadEnter) && cooldown2 >= 3)
        {
            Vector3 worldPos2 = player.transform.position;
            Vector3Int cell2 = tilemap.WorldToCell(worldPos2);
            Vector3 cellCenterPos2 = tilemap.GetCellCenterWorld(cell2);
            
            Instantiate(bombPrefab, cellCenterPos2, Quaternion.identity);
            
            FindObjectOfType<BombExplode>().keissi = firepower2;
           
            cooldown2 = 0;
        }

        if (gameObject.tag == "Player2" && bombcount2 >= 2 && Input.GetKeyUp(KeyCode.KeypadEnter))
        {

            Vector3 worldPos2 = player.transform.position;
            Vector3Int cell2 = tilemap.WorldToCell(worldPos2);
            Vector3 cellCenterPos2 = tilemap.GetCellCenterWorld(cell2);

            Instantiate(bombPrefab, cellCenterPos2, Quaternion.identity);
            FindObjectOfType<BombExplode>().keissi = firepower2;

            bombcount2--;
            Invoke("AddBomb2", 1);
        }

        //Player3

        if (gameObject.tag == "Player3" && Input.GetKeyDown(KeyCode.B) && cooldown3 >= 3)
        {
            Vector3 worldPos3 = player.transform.position;
            Vector3Int cell3 = tilemap.WorldToCell(worldPos3);
            Vector3 cellCenterPos3 = tilemap.GetCellCenterWorld(cell3);
            
            Instantiate(bombPrefab, cellCenterPos3, Quaternion.identity);
           
            FindObjectOfType<BombExplode>().keissi = firepower3;
            
            cooldown3 = 0;
        }

        if (gameObject.tag == "Player3" && bombcount3 >= 2 && Input.GetKeyDown(KeyCode.B))
        {
            Vector3 worldPos3 = player.transform.position;
            Vector3Int cell3 = tilemap.WorldToCell(worldPos3);
            Vector3 cellCenterPos3 = tilemap.GetCellCenterWorld(cell3);

            Instantiate(bombPrefab, cellCenterPos3, Quaternion.identity);

            FindObjectOfType<BombExplode>().keissi = firepower3;

            bombcount3--;
            Invoke("AddBomb3", 1);
        }

        //Player4

        if (gameObject.tag == "Player4" && Input.GetKeyDown(KeyCode.LeftShift) && cooldown4 >= 3)
        {
            Vector3 worldPos4 = player.transform.position;
            Vector3Int cell4 = tilemap.WorldToCell(worldPos4);
            Vector3 cellCenterPos4 = tilemap.GetCellCenterWorld(cell4);
           
            Instantiate(bombPrefab, cellCenterPos4, Quaternion.identity);
            
            FindObjectOfType<BombExplode>().keissi = firepower4;
            
            cooldown4 = 0;
        }

        if (gameObject.tag == "Player4" && bombcount4 >= 2 && Input.GetKeyDown(KeyCode.LeftShift))
        {
            Vector3 worldPos4 = player.transform.position;
            Vector3Int cell4 = tilemap.WorldToCell(worldPos4);
            Vector3 cellCenterPos4 = tilemap.GetCellCenterWorld(cell4);

            Instantiate(bombPrefab, cellCenterPos4, Quaternion.identity);

            FindObjectOfType<BombExplode>().keissi = firepower4;

            bombcount4--;
            Invoke("AddBomb4", 1);
        }
    } 

    //silly way of adding the second bomb if bombcounts are 2 or above because of the Update().

    public void AddBomb()
    {
        
        bombcount1++;
    }

    public void AddBomb2()
    {
        bombcount2++;
    }

    public void AddBomb3()
    {
        bombcount3++;
    }

    public void AddBomb4()
    {
        bombcount4++;
    }
}

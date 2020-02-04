using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapDestroyer : MonoBehaviour
{
    public Tilemap tilemap;

    public Tile wallTile;
    public Tile destructibleTile;

    public GameObject explosionPrefab;

    GameObject cloneExplosion;

    public int keissi = 1; // changes the explosion range, this is determined from BombExplode and BombSpawner scripts.

    public bool destroyed = false; //checks if a destructible tile from that direction is already destroyed


    public void Explode(Vector2 worldPos)
    {
        Vector3Int originCell = tilemap.WorldToCell(worldPos);

        if (keissi == 1)
        {
            ExplodeCell(originCell);
            Destroy(cloneExplosion, 0.5f);
            ExplodeCell(originCell + new Vector3Int(1, 0, 0));
            Destroy(cloneExplosion, 0.5f);
            ExplodeCell(originCell + new Vector3Int(-1, 0, 0));
            Destroy(cloneExplosion, 0.5f);
            ExplodeCell(originCell + new Vector3Int(0, 1, 0));
            Destroy(cloneExplosion, 0.5f);
            ExplodeCell(originCell + new Vector3Int(0, -1, 0));
            Destroy(cloneExplosion, 0.5f);
            destroyed = false;
        }

        if (keissi == 2)
        {
            ExplodeCell(originCell);
            Destroy(cloneExplosion, 0.5f);
            if (ExplodeCell(originCell + new Vector3Int(1, 0, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    ExplodeCell(originCell + new Vector3Int(2, 0, 0));
                    Destroy(cloneExplosion, 0.5f);
                }
            }

            if (ExplodeCell(originCell + new Vector3Int(-1, 0, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    ExplodeCell(originCell + new Vector3Int(-2, 0, 0));
                    Destroy(cloneExplosion, 0.5f);
                }
            }

            if (ExplodeCell(originCell + new Vector3Int(0, 1, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    ExplodeCell(originCell + new Vector3Int(0, 2, 0));
                    Destroy(cloneExplosion, 0.5f);
                }
            }

            if (ExplodeCell(originCell + new Vector3Int(0, -1, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    ExplodeCell(originCell + new Vector3Int(0, -2, 0));
                    Destroy(cloneExplosion, 0.5f);
                }
            }
            destroyed = false;
        }

        if(keissi == 3)
        {
            ExplodeCell(originCell);
            Destroy(cloneExplosion, 0.5f);
            if (ExplodeCell(originCell + new Vector3Int(1, 0, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    if (ExplodeCell(originCell + new Vector3Int(2, 0, 0)))
                    {
                        Destroy(cloneExplosion, 0.5f);
                        if (destroyed == false)
                        {
                            ExplodeCell(originCell + new Vector3Int(3, 0, 0));
                            Destroy(cloneExplosion, 0.5f);
                        }
                    }
                }   
            }

            if (ExplodeCell(originCell + new Vector3Int(-1, 0, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    if (ExplodeCell(originCell + new Vector3Int(-2, 0, 0)))
                    {
                        Destroy(cloneExplosion, 0.5f);
                        if (destroyed == false)
                        {
                            ExplodeCell(originCell + new Vector3Int(-3, 0, 0));
                            Destroy(cloneExplosion, 0.5f);
                        }
                    }
                }
            }

            if (ExplodeCell(originCell + new Vector3Int(0, 1, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    if (ExplodeCell(originCell + new Vector3Int(0, 2, 0)))
                    {
                        Destroy(cloneExplosion, 0.5f);
                        if (destroyed == false)
                        {
                            ExplodeCell(originCell + new Vector3Int(0, 3, 0));
                            Destroy(cloneExplosion, 0.5f);
                        }
                    }
                }
                
            }

            if (ExplodeCell(originCell + new Vector3Int(0, -1, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    if (ExplodeCell(originCell + new Vector3Int(0, -2, 0)))
                    {
                        Destroy(cloneExplosion, 0.5f);
                        if (destroyed == false)
                        {
                            ExplodeCell(originCell + new Vector3Int(0, -3, 0));
                            Destroy(cloneExplosion, 0.5f);
                        }
                    }
                }
            }
            destroyed = false;
        }

        if (keissi >= 4)
        {
            ExplodeCell(originCell);
            Destroy(cloneExplosion, 0.5f);
            if (ExplodeCell(originCell + new Vector3Int(1, 0, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    if (ExplodeCell(originCell + new Vector3Int(2, 0, 0)))
                    {
                        Destroy(cloneExplosion, 0.5f);
                        if (destroyed == false)
                        {
                            if (ExplodeCell(originCell + new Vector3Int(3, 0, 0)))
                            {
                                Destroy(cloneExplosion, 0.5f);
                                if(destroyed == false)
                                {
                                    ExplodeCell(originCell + new Vector3Int(4, 0, 0));
                                    Destroy(cloneExplosion, 0.5f);
                                }
                            }
                        }
                    }
                }
            }

            if (ExplodeCell(originCell + new Vector3Int(-1, 0, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    if (ExplodeCell(originCell + new Vector3Int(-2, 0, 0)))
                    {
                        Destroy(cloneExplosion, 0.5f);
                        if (destroyed == false)
                        {
                            if (ExplodeCell(originCell + new Vector3Int(-3, 0, 0)))
                            {
                                Destroy(cloneExplosion, 0.5f);
                                if (destroyed == false)
                                {
                                    ExplodeCell(originCell + new Vector3Int(-4, 0, 0));
                                    Destroy(cloneExplosion, 0.5f);
                                }
                            }
                        }
                    }
                }
            }

            if (ExplodeCell(originCell + new Vector3Int(0, 1, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    if (ExplodeCell(originCell + new Vector3Int(0, 2, 0)))
                    {
                        Destroy(cloneExplosion, 0.5f);
                        if (destroyed == false)
                        {
                            if (ExplodeCell(originCell + new Vector3Int(0, 3, 0)))
                            {
                                Destroy(cloneExplosion, 0.5f);
                                if (destroyed == false)
                                {
                                    ExplodeCell(originCell + new Vector3Int(0, 4, 0));
                                    Destroy(cloneExplosion, 0.5f);
                                }
                            }
                        }
                    }

                }
            }

            if (ExplodeCell(originCell + new Vector3Int(0, -1, 0)))
            {
                Destroy(cloneExplosion, 0.5f);
                if (destroyed == false)
                {
                    if (ExplodeCell(originCell + new Vector3Int(0, -2, 0)))
                    {
                        Destroy(cloneExplosion, 0.5f);
                        if (destroyed == false)
                        {
                            if (ExplodeCell(originCell + new Vector3Int(0, -3, 0)))
                            {
                                Destroy(cloneExplosion, 0.5f);
                                if (destroyed == false)
                                {
                                    ExplodeCell(originCell + new Vector3Int(0, -4, 0));
                                    Destroy(cloneExplosion, 0.5f);
                                }
                            }
                        }
                    }
                }
            }
            destroyed = false;
        }
    }

    bool ExplodeCell(Vector3Int cell) //checking whether the tile explosion is hitting is destructible, indestructible or nothing;
    {
        Tile tile = tilemap.GetTile<Tile>(cell);
        
        if(tile == wallTile) //explosion doesn't continue nor is the tile destroyed.
        {
            return false;
        }

        if(tile == null) //the explosion may continue to this direction because there is nothing blocking it.
        {
            destroyed = false;
        }

        if(tile == destructibleTile) //the explosion destroyes this tile but goes no further.
        {
            //remove tile
            tilemap.SetTile(cell, null);
            destroyed = true;
        }
        
        Vector3 pos = tilemap.GetCellCenterWorld(cell);
        cloneExplosion = Instantiate(explosionPrefab, pos, Quaternion.identity); //for removing the clone explosions from the game.
       
        return true;
    }
    
}

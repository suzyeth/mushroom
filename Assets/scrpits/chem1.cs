using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class chem1 : MonoBehaviour
{
    
    public GameObject[] FishPrefab;
    public GameObject[] FishPrefab1;
    public GameObject[] FishPrefab2;
    public GameObject[] FishPrefab3;


    public GameObject[] DectPrefab;
    
    //计时器
    float timer = 0;

    float positonx;
    float positony;

    


    


    int random1;
    int random2;
    int n = 0;

   
    

    /*public float lifetime;//定义一个消失的时间
    public GameObject _enemyship;//接收需要加载的物体

    public int enemyCount;//定义生成的个数

    public float WaitTime; //定义一个时间，让怪物在游戏开始一段时间后才开始加载

    public float NextTime;//生成下一波怪物的时间间隔

    public Rigidbody2D projectile;
    */

    
    // Start is called before the first frame update
    void Start()
    {
       
        /*StartCoroutine(spawnWaves());

          print (positonx);

         Destroy(gameObject, lifetime);//达到时间自动消除。*/
    }



    void Update()

    {
        /*timeBetween += Time.deltaTime;
        if(timeBetween>spawnTime)
        {
            random1 = Random.Range(0, 3);
            random2 = Random.Range(3, 6);
            positony = chems[random1];
            positonx = chems[random2];
            Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(2.15f, positony), Quaternion.identity);
                timeBetween = 0;
        }



        random1 = Random.Range(0, 3);
            random2 = Random.Range(3, 6);
            positony = chems[random1];
            positonx = chems[random2];

        */
        random1 = Random.Range(0, 3);
        random2 = Random.Range(3, 6);
        

        timer += Time.deltaTime;
        //三秒生成一个

        if (timer >= 8)

        {

            timer = 0;
            n += 1;
            //左侧
            Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], DectPrefab[Random.Range(0, 2)].transform.position, Quaternion.identity);

            print(timer);
            //右侧

            Instantiate(FishPrefab1[Random.Range(0, FishPrefab1.Length)], DectPrefab[Random.Range(3, 5)].transform.position, Quaternion.identity);
            //上方
           Instantiate(FishPrefab2[Random.Range(0, FishPrefab2.Length)], DectPrefab[Random.Range(6, 8)].transform.position, Quaternion.identity);
            //下方
            Instantiate(FishPrefab3[Random.Range(0, FishPrefab3.Length)], DectPrefab[Random.Range(9, 11)].transform.position, Quaternion.identity);
            
            /*for(int i =0;i<10;i++)
            {
                Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(2.15f, positony), Quaternion.identity)

            }*/
            //生成预制物体

            //Instantiate(，，)；第一个参数写随机Random.Range(0, 数组的长度也就是预制物体的个数)]，第二个参数写生成的位置，第三个参数写旋转(也可以不旋转Quaternion.identity)
            //左侧
            /*GameObject leftFish = Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(2.15f, positony), Quaternion.identity) as GameObject;
            leftFish.transform.position =*/
            /*Destroy(leftFish, 1f);*/
            /*leftFish.GetComponent<Fish>().SetTarget(left_targets[random1].transform);*/
            //右侧

            /*GameObject rightFish = Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(15.6f, positony), Quaternion.identity);
            /*rightFish.GetComponent<Fish>().SetTarget(right_targets[random1].transform);*/
            /*rightFish.transform.position=

            //上方
           /* Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(positonx, 4.26f), Quaternion.identity);
            //下方
            Instantiate(FishPrefab[Random.Range(0, FishPrefab.Length)], new Vector2(positonx, -8.73f), Quaternion.identity);



            //计时器归零

            
            print(timer);}*/



            /*IEnumerator spawnWaves()

            {

                yield return new WaitForSeconds(WaitTime); //在游戏开始后会在waittime时间后才开始执行

                while(true)

                {

                    for(int i = 0; i < enemyCount)

                    {

                        Vector3 shipPosition = new Vector3(Random.Range(-1000, 1000), Random.Range(-1000, 1000), Random.Range(-1000, 1000));//设置生成物体的随机坐标
                        Quaternion shipRotation = Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));//设置生成物体的随机角度
                        Instantiate(_enemyShip, shipPosition, shipRotation);//生成物体
                        yield return new WaitForSeconds(spawnTime);//限制生成时间间隔

                    }

                }

            }*/










        }
    }
}

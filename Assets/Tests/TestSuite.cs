using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestSuite
{
    private MovementEnemy MEnemy;
    private SpawningEnemies SEnemy;

    // 1
    [UnityTest]
    public IEnumerator EnemiesMovingDown()
    {
        // 2
        GameObject gameGameObject =
            MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/EnemyObstacleSimple"));
        SEnemy = gameGameObject.GetComponent<SpawningEnemies>();
        // 3
        GameObject enemy = SEnemy.GetSpawner().SpawnAsteroid();
        // 4
        float initialYPos = asteroid.transform.position.y;
        // 5
        yield return new WaitForSeconds(0.1f);
        // 6
        Assert.Less(asteroid.transform.position.y, initialYPos);
        // 7
        Object.Destroy(game.gameObject);
    }

}
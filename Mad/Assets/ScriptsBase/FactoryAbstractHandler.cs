using UnityEngine;

public class FactoryAbstractHandler : GSC<FactoryAbstractHandler>
{
    [SerializeField]
    private Enemy _enemyPrefab, _enemyPistolManPrefab;
    [SerializeField]
    private FactoryEnemy _factoryEnemy;

    [SerializeField]
    private Hero _heroPrefab;
    [SerializeField]
    private FactoryHero _factoryHero;

    public Hero CreateHero()
    {
        return _factoryHero.Create(_heroPrefab);
    }

    public Enemy CreateEnemy()
    {
        return _factoryEnemy.Create(_enemyPrefab);
    }

    public Enemy CreateEnemyPistolMan()
    {
        return _factoryEnemy.Create(_enemyPistolManPrefab);
    }
}

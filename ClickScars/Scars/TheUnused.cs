﻿using API = RL2.API;
using Collections = System.Collections.Generic;

public struct TheUnused : API.IRegistrable
{
    public void Register()
    {
        API.Scars.ModifySummonRules.Event += ModifyDivergentDimensions;
    }

    private void ModifyDivergentDimensions(ChallengeType challenge, ref Collections.List<BaseSummonRule> rules)
    {
        if (challenge != ChallengeType.TwoRebels) return;

        var count = rules.Count - 1;
        for (var i = count - 10; i > 6; i--)
        {
            rules.RemoveAt(i);
        }

        Collections.List<BaseSummonRule> newRules = [
            new API.SummonRule.SetEnemyLevel()
            {
                SetToRoomLevel = true,
                Level = 20,
            },

            new API.SummonRule.SetSpawnPoints() { SpawnPoints = [1] },
            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalBounce, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1 },

            new API.SummonRule.SetSpawnPoints() { SpawnPoints = [1] },
            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalCurse, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1 },

            new API.SummonRule.SetSpawnPoints() { SpawnPoints = [1] },
            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalDash, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1 },

            new API.SummonRule.SetSpawnPoints() { SpawnPoints = [1] },
            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalFire, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1 },

            new API.SummonRule.SetSpawnPoints() { SpawnPoints = [1] },
            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalIce, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1 },

            new WaitUntilXRemaining_SummonRule()
        ];

        rules.InsertRange(6, newRules);
    }
}
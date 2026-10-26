using API = RL2.API;
using Collections = System.Collections.Generic;

public struct CeremonyOfReturn : API.IRegistrable
{
    public void Register()
    {
        API.Scars.ModifySummonRules.Event += ModifyArmada;
    }

    private void ModifyArmada(ChallengeType challenge, ref Collections.List<BaseSummonRule> rules)
    {
        if (challenge != ChallengeType.BigBattle) return;

        var count = rules.Count - 1;
        for (var i = count - 10; i > 6; i--)
        {
            rules.RemoveAt(i);
        }

        Collections.List<BaseSummonRule> newRules = [
            new API.SummonRule.DisplayObjectiveComplete() {
                HUDType = ObjectiveCompleteHUDType.Scar,
                BossLocIDOverride = "Discord servers when you @everyone",
            },
            new API.SummonRule.SetEnemyLevel()
            {
                Level = 1,
                SetToRoomLevel = false
            },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ArcThrower, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ArcThrower, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ArcThrower, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.AxeKnight, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.AxeKnight, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.AxeKnight, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.BlobFish, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.BlobFish, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.BlobFish, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.BouncySpike, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.BouncySpike, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.BouncySpike, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.BouncySpike, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalBounce, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalBounce, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalBounce, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalCurse, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalCurse, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalCurse, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalDash, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalDash, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalDash, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalFire, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalFire, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalFire, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalIce, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalIce, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.ElementalIce, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Eyeball, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Eyeball, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Eyeball, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Eyeball, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Fireball, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Fireball, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Fireball, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingBurst, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingBurst, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingBurst, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingBurst, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingHunter, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingHunter, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingHunter, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingSkull, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingSkull, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingSkull, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingAxe, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingAxe, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingAxe, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingAxe, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingHammer, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingHammer, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingHammer, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingHammer, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingShield, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingShield, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingShield, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingShield, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingSword, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingSword, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingSword, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingSword, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.MimicChest, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.MimicChest, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.MimicChest, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.MimicChest, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.PaintingEnemy, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.PaintingEnemy, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.PaintingEnemy, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Plant, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Plant, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Plant, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.RocketBox, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.RocketBox, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.RocketBox, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.RocketBox, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FlyingAxe, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Skeleton, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Skeleton, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Skeleton, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SkeletonArcher, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SkeletonArcher, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SkeletonArcher, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SkeletonArcher, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Slug, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Slug, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Slug, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Slug, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Sniper, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Sniper, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Sniper, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SpearKnight, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SpearKnight, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SpearKnight, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SpearKnight, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Starburst, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Starburst, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Starburst, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Starburst, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SwordKnight, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SwordKnight, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SwordKnight, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SwordKnight, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.TopShotHazard, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.TopShotHazard, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.TopShotHazard, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Volcano, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Volcano, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Volcano, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Wolf, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Wolf, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Wolf, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Wolf, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Zombie, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Zombie, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.Zombie, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SpellswordBoss, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SpellswordBoss, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SpellswordBoss, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SkeletonBossA, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SkeletonBossA, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SkeletonBossB, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.SkeletonBossB, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.DancingBoss, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.DancingBoss, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.StudyBoss, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.StudyBoss, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.MimicChestBoss, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.MimicChestBoss, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.EyeballBoss_Bottom, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.EyeballBoss_Middle, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.EyeballBoss_Middle, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.CaveBoss, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.CaveBoss, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.TraitorBoss, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.TraitorBoss, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.TraitorBoss, EnemyRank.Expert)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.TraitorBoss, EnemyRank.Miniboss)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FinalBoss, EnemyRank.Basic)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

            new API.SummonRule.SetEnemyPool()
            {
                EnemyPool = [new(EnemyType.FinalBoss, EnemyRank.Advanced)],
                IsBiomeSpecific = false,
                FlyingOnly = false
            },
            new API.SummonRule.SummonEnemies() { SummonValue = 1, SummonDelay = 0, RandomizeOnce = true, SpawnFast = false, SpawnAsCommander = false },

        ];

        rules.InsertRange(6, newRules);
    }
}
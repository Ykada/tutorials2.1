using UnityEngine;

public class EarlyReturns : MonoBehaviour
{
    //bool IsPlayerReadyToAttack(Player player)
    //{
    //    if (player == null)
    //        return false;
    //    if (!player.IsAlive)
    //        return false;
    //    if (player.AttackCooldown > 0)
    //        return false;
    //    if (player.Target == null)
    //        return false;
    //    if (!player.Target.IsAlive)
    //        return false;
    //    float distance = Vector3.Distance(
    //        player.transform.position,
    //        player.Target.transform.position
    //    );
    //    if (distance >= 5f)
    //        return false;
    //    bool hasManaAndWeapon = player.Mana >= 20 && player.WeaponEquipped;
    //    bool hasHealthAndBuff = player.Health > 30 && player.HasBuff("Strength");

    //    if (!hasManaAndWeapon && !hasHealthAndBuff)
    //        return false;
    //    if (player.IsStunned)
    //        return false;
    //    if (player.IsSlowed)
    //        return false;
    //    return true;
    //}
}

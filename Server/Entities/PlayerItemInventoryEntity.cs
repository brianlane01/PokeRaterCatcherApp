using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class PlayerItemInventoryEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string NameOfPlayer { get; set; } = string.Empty;

    public virtual List<PlayerEntity> Players { get; set; } 

    //* Creates Many to Many relationships so that I can utilize the various items stored in these other tables as a player's Inventory....
    public ICollection<HealthItemEntity> HealthItems { get; set; } 
    public ICollection<RejuvenationItemEntity> ReviveItems { get; set; }
    public ICollection<PokeBallEntity> PokeBalls { get; set; }
    public ICollection<StatusConditionItemEntity> RemoveStatusConditionItems { get; set; }
    public ICollection<TechnicalMachineMoveEntity> TMs { get; set; }

    public PlayerItemInventoryEntity()
    {
        HealthItems = new HashSet<HealthItemEntity>();
        ReviveItems = new HashSet<RejuvenationItemEntity>();
        PokeBalls = new HashSet<PokeBallEntity>();
        RemoveStatusConditionItems = new HashSet<StatusConditionItemEntity>();
        TMs = new HashSet<TechnicalMachineMoveEntity>();
    }


}

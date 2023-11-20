using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class RejuvenationItemEntity
{
    [Key]
    public int Id { get; set; }

    [Required, MinLength(4), MaxLength(100)]
    public string RejuvenationItemName { get; set; } = string.Empty;

    [Required, MinLength(4), MaxLength(800)]
    public string RejuvenationItemDescription { get; set; } = string.Empty;

    [Required, Range(1, 400)]
    public double ReviveHealthAmount { get; set; }

    [Required]
    public bool ReviveAllFaintedPokemon{ get; set; }

    public ICollection<PlayerItemInventoryEntity> PlayerInventory { get; set; }

    public RejuvenationItemEntity()
    {
        PlayerInventory = new HashSet<PlayerItemInventoryEntity>();
    }
}

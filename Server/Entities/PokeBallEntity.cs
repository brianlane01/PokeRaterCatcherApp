using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class PokeBallEntity
{
    [Key]
    public int Id { get; set; }

    [Required, MinLength(4), MaxLength(55)]
    public string NameOfBall { get; set; } = string.Empty;

    [Required, MinLength(4), MaxLength(1000)]
    public string DescriptionOfPokeBall { get; set; } = string.Empty;

    [Required]
    public double CatchRate { get; set; }

    public ICollection<PlayerItemInventoryEntity> PlayerInventory { get; set; }

    public PokeBallEntity()
    {
        PlayerInventory = new HashSet<PlayerItemInventoryEntity>();
    }
}

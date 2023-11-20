using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PokemonCatcherGame.Server.Entities;

namespace Server.Entities;

public class PlayerEntity
{
    [Key]
    public int Id { get; set; }

    [Required, MinLength(4), MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [ForeignKey(nameof(User))]
    public string UserId { get; set; } =string.Empty;
    public virtual ApplicationUser? User {get; set;}

    [ForeignKey(nameof(ItemInventory))]
    public int ItemIventoryId { get; set; }
    public virtual PlayerItemInventoryEntity? ItemInventory { get; set; }

    // //* Creates a many to many relationship that will store all the pokemon the player has 'Caught' so that the pokemon's 
    // //* info can be utilized with the player. 
    public virtual ICollection<PokemonEntity> CaughtPokemon { get; set; }

    public PlayerEntity()
    {
        CaughtPokemon = new HashSet<PokemonEntity>();
    }

}

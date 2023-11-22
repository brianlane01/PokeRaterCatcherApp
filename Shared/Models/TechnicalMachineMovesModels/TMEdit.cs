using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models.TechnicalMachineMovesModels;

public class TMEdit
{
    public int Id { get; set; }

    [Required]
    public string TMNumber { get; set; } = string.Empty;

    [Required, MinLength(3), MaxLength(70)]
    public string MoveName { get; set; } = string.Empty;

    [Required, MinLength(3), MaxLength(250)]
    public string MoveDescription { get; set; } = string.Empty;

    [Required, Range(1, 55)]
    public int MoveBasePP { get; set; }    //* Determines how many times a move can be used. c

    [Required, Range(0, 200)]
    public int MovePower { get; set; }

    [Required, Range(0, 100)]
    public int MoveAccuracy { get; set; }

    [Required, MinLength(3), MaxLength(70)]
    public string MoveType { get; set; } = string.Empty;

    [Required]
    public bool MoveRestoresHealth { get; set; }

    [Range(1, 300)]
    public int HealthRestorationAmount { get; set; }

    [Required]
    public bool MoveAppliesAStatusCondition { get; set; }

    //* Establishes a Relationship with the StatusConditions Table so that the PokemonMoves can use the information stored in that Table..
    public int StatusConditionId { get; set; }
    
    //* Checks to determine what types of pokemon can learn the move
    public bool PsychicCanLearn { get; set; } 
    public bool FireCanLearn { get; set; }
    public bool GrassCanLearn { get; set; }
    public bool ElectricCanLearn { get; set; }
    public bool FightingCanLearn { get; set; }
    public bool FairyCanLearn { get; set; }
    public bool DragonCanLearn { get; set; }
    public bool PoisonCanLearn { get; set; }
    public bool BugCanLearn { get; set; }
    public bool WaterCanLearn { get; set; }
    public bool RockCanLearn { get; set; }
    public bool GroundCanLearn { get; set; }
    public bool GhostCanLearn { get; set; }
    public bool DarkCanLearn { get; set; }
    public bool SteelCanLearn { get; set; }
    public bool NormalCanLearn { get; set; }
    public bool IceCanLearn { get; set; }
    public bool FlyingCanLearn { get; set; }
}

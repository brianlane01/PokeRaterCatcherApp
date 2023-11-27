using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class InventoryForScrEntity
{
    [Key]
    public int Id { get; set; }
    public int PlayerInventoryId { get; set; }
    public int RemoveStatusConditionItemsId { get; set; }

    // Navigation properties
    public PlayerItemInventoryEntity? PlayerItemInventory { get; set; }
    public StatusConditionItemEntity? RemoveStatusConditionItem { get; set; }
}

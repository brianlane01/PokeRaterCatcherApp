using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class HealthItemInventoryEntity
{
    [Key, Column(Order = 0), ForeignKey("PlayerItemInventory")]
    public int PlayerItemInventoryId { get; set; }
    public virtual PlayerItemInventoryEntity PlayerItemInventory { get; set; } = null!;

    [Key, Column(Order = 1), ForeignKey("HealthItem")]
    public int HealthItemId { get; set; } 
    public virtual HealthItemEntity HealthItem { get; set; } = null!;  

    public int Quantity { get; set; }
}

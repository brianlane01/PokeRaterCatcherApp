using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Entities;

public class InventoryHealthItemEntity
{
    public int PlayerInventoryId { get; set; }
    public virtual PlayerItemInventoryEntity PlayerItemInventory { get; set; } = null!;
    
    public int HealthItemId { get; set; }
    public virtual HealthItemEntity HealthItem { get; set; } = null!;

    public int ItemQuantity { get; set; }
}

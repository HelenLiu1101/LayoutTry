using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

public partial class SysGroup
{
    public Guid GroupUuid { get; set; }

    public string? SystemId { get; set; }

    public string? OrgId { get; set; }

    public string GroupId { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public string? AdminGroup { get; set; }

    public string StatusFlag { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }
}

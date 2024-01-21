using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

public partial class SysGroupProgram
{
    public Guid PermissionUuid { get; set; }

    public Guid GroupUuid { get; set; }

    public Guid FuncUuid { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace LayoutTry.Models;

public partial class SysProgram
{
    public Guid FuncUuid { get; set; }

    public string? FuncType { get; set; }

    public Guid? SuperUuid { get; set; }

    public string FuncId { get; set; } = null!;

    public string? FuncSid { get; set; }

    public string FuncName { get; set; } = null!;

    public string? FuncUrl { get; set; }

    public string? SystemId { get; set; }

    public int? SeqNo { get; set; }

    public Guid? FlowUuid { get; set; }

    public string? Descriptions { get; set; }

    public string? StatusFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public string? FuncEntity { get; set; }

    public string? TableName { get; set; }

    public string? KeyName { get; set; }

    public string? FuncClass { get; set; }

    public string? NewTab { get; set; }
}

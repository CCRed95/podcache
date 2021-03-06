﻿using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace podcache.Data.Domain.Responses
{
  [DebuggerDisplay("{DebuggerDisplay}")]
  public class Doc
  {
    public string Creator { get; set; }

    public DateTime Date { get; set; }

    public string Description { get; set; }

    public string Identifier { get; set; }

    public string Mediatype { get; set; }

    public string Title { get; set; }

    [JsonIgnore]
    public string DebuggerDisplay
    {
      get => $"Upload: {Identifier} | {Title}";
    }
  }
}
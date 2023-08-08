using Gw2Sharp.Mumble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Estreya.MumbleMock.Models;
internal class Context
{
    public string? MapId { get; set; }
    public string? MapType { get; set; }
    public string? BuildId { get; set; }
    public UiState UiState { get; set; }
    public ushort CompassWidth { get; set; }
    public ushort CompassHeight { get; set;    }
    public float CompassRotation { get; set; }

    public Vector2 PlayerPosition { get; set; }
    public Vector2 MapCenter { get; set; }
    public float MapScale { get; set; }

    public string? Mount { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Estreya.MumbleMock.Models;
internal class SaveData
{
    public Vector3 AvatarPosition { get; set; }
    public Vector3 AvatarFront { get; set; }
    public Vector3 AvatarTop { get; set; } 

    public Vector3 CameraPosition { get; set; }
    public Vector3 CameraFront { get; set; }
    public Vector3 CameraTop { get; set;}

    public Identity? Identity { get; set; }

    public Context? Context { get; set; }
}

using Gw2Sharp.Mumble;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estreya.MumbleMock.MumbleLink;
public class Gw2MumbleClientWriter
{
    private MemoryMappedFile? file;
    private MemoryMappedViewAccessor? accessor;

    private readonly string mumbleLinkName;

    public string MumbleLinkName => mumbleLinkName;

    /// <summary>
    /// Creates a new <see cref="Gw2MumbleClientReader"/>.
    /// </summary>
    /// <param name="mumbleLinkName">The Mumble Link name.</param>
    /// <exception cref="PlatformNotSupportedException">Only Windows operating systems are supported.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="mumbleLinkName"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException"><paramref name="mumbleLinkName"/> is an empty string or only contains whitespaces.</exception>
    public Gw2MumbleClientWriter(string mumbleLinkName)
    {
#if NET5_0_OR_GREATER
        if (!OperatingSystem.IsWindows())
#else
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
#endif
            throw new PlatformNotSupportedException("Only Windows operating systems support the Mumble Link");

        if (mumbleLinkName is null)
            throw new ArgumentNullException(nameof(mumbleLinkName));
        if (string.IsNullOrWhiteSpace(mumbleLinkName))
            throw new ArgumentException($"'{nameof(mumbleLinkName)}' may not be empty or only contain whitespaces", nameof(mumbleLinkName));

        this.mumbleLinkName = mumbleLinkName;
    }

    /// <inheritdoc/>
    public bool IsOpen { get; private set; }

    /// <inheritdoc/>
    public void Open()
    {
        this.file = MemoryMappedFile.CreateOrOpen(this.mumbleLinkName, Gw2LinkedMem.SIZE, MemoryMappedFileAccess.ReadWrite);
        this.accessor = this.file.CreateViewAccessor();
        this.IsOpen = true;
    }

    /// <inheritdoc/>
    public void Close()
    {
        this.accessor?.Dispose();
        this.file?.Dispose();

        this.accessor = null;
        this.file = null;
        this.IsOpen = false;
    }

    /// <inheritdoc/>
    public void Write(Gw2LinkedMem gw2LinkedMem)
    {
        if (this.isDisposed)
            throw new ObjectDisposedException(nameof(Gw2MumbleClientWriter));
        if (this.file is null || this.accessor is null)
            throw new InvalidOperationException("The writer has to be opened first");

        this.accessor.Write<Gw2LinkedMem>(0, ref gw2LinkedMem);
    }


    #region IDisposable Support

    private bool isDisposed = false; // To detect redundant calls

    /// <summary>
    /// Disposes the object.
    /// </summary>
    /// <param name="disposing">Dispose managed resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (this.isDisposed)
            return;

        if (disposing)
        {
            this.Close();
        }

        this.isDisposed = true;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    #endregion
}

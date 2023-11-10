using System;
using System.Drawing;

namespace GOLNET001
{
  public class UniverseEventArgs : EventArgs
  {
    private Universe universe;

    public Size Size => this.universe.Size;

    public int LivingCells => this.universe.LivingCells;

    public int Generation => this.universe.Generation;

    public UniverseEventArgs(Universe universe) => this.universe = universe;
  }
}

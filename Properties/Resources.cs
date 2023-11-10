using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace GOLNET001.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (GOLNET001.Properties.Resources.resourceMan == null)
          GOLNET001.Properties.Resources.resourceMan = new ResourceManager("GOLNET001.Properties.Resources", typeof (GOLNET001.Properties.Resources).Assembly);
        return GOLNET001.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => GOLNET001.Properties.Resources.resourceCulture;
      set => GOLNET001.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap arrow_Next_16xLG_color => (Bitmap) GOLNET001.Properties.Resources.ResourceManager.GetObject(nameof (arrow_Next_16xLG_color), GOLNET001.Properties.Resources.resourceCulture);

    internal static Bitmap arrow_run_16xLG => (Bitmap) GOLNET001.Properties.Resources.ResourceManager.GetObject(nameof (arrow_run_16xLG), GOLNET001.Properties.Resources.resourceCulture);

    internal static Bitmap Symbols_Pause_16xLG => (Bitmap) GOLNET001.Properties.Resources.ResourceManager.GetObject(nameof (Symbols_Pause_16xLG), GOLNET001.Properties.Resources.resourceCulture);
  }
}

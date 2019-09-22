//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArcmapSpy {
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcMapUI;
    using ESRI.ArcGIS.Editor;
    using ESRI.ArcGIS.esriSystem;
    using System;
    using System.Collections.Generic;
    using ESRI.ArcGIS.Desktop.AddIns;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal static class ThisAddIn {
        
        internal static string Name {
            get {
                return "ArcmapSpy";
            }
        }
        
        internal static string AddInID {
            get {
                return "{e6860651-3588-47ea-bf4f-17479c011f19}";
            }
        }
        
        internal static string Company {
            get {
                return "Geocom Informatik AG";
            }
        }
        
        internal static string Version {
            get {
                return "2.2.0";
            }
        }
        
        internal static string Description {
            get {
                return "Explores the internals of a running ArcMap instance.";
            }
        }
        
        internal static string Author {
            get {
                return "Stoeckli Martin";
            }
        }
        
        internal static string Date {
            get {
                return "06.12.2018";
            }
        }
        
        internal static ESRI.ArcGIS.esriSystem.UID ToUID(this System.String id) {
            ESRI.ArcGIS.esriSystem.UID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = id;
            return uid;
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'Geocom_Informatik_AG_ArcmapSpy_LayerSpyCommand', the id declared for Add-in Button class 'LayerSpyCommand'
            /// </summary>
            internal static string LayerSpyCommand {
                get {
                    return "Geocom_Informatik_AG_ArcmapSpy_LayerSpyCommand";
                }
            }
            
            /// <summary>
            /// Returns 'Geocom_Informatik_AG_ArcmapSpy_ApplicationSpyCommand', the id declared for Add-in Button class 'ApplicationSpyCommand'
            /// </summary>
            internal static string ApplicationSpyCommand {
                get {
                    return "Geocom_Informatik_AG_ArcmapSpy_ApplicationSpyCommand";
                }
            }
            
            /// <summary>
            /// Returns 'Geocom_Informatik_AG_ArcmapSpy_FeatureSpyTool', the id declared for Add-in Tool class 'FeatureSpyTool'
            /// </summary>
            internal static string FeatureSpyTool {
                get {
                    return "Geocom_Informatik_AG_ArcmapSpy_FeatureSpyTool";
                }
            }
            
            /// <summary>
            /// Returns 'Geocom_Informatik_AG_ArcmapSpy_GeometrySpyTool', the id declared for Add-in Tool class 'GeometrySpyTool'
            /// </summary>
            internal static string GeometrySpyTool {
                get {
                    return "Geocom_Informatik_AG_ArcmapSpy_GeometrySpyTool";
                }
            }
            
            /// <summary>
            /// Returns 'Geocom_Informatik_AG_ArcmapSpy_WorkspaceSpyCommand', the id declared for Add-in Button class 'WorkspaceSpyCommand'
            /// </summary>
            internal static string WorkspaceSpyCommand {
                get {
                    return "Geocom_Informatik_AG_ArcmapSpy_WorkspaceSpyCommand";
                }
            }
        }
    }
    
internal static class ArcMap
{
  private static IApplication s_app = null;
  private static IDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
      {
        s_app = Internal.AddInStartupObject.GetHook<IMxApplication>() as IApplication;
        if (s_app == null)
        {
          IEditor editorHost = Internal.AddInStartupObject.GetHook<IEditor>();
          if (editorHost != null)
            s_app = editorHost.Parent;
        }
      }
      return s_app;
    }
  }

  public static IMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IMxDocument;

      return null;
    }
  }
  public static IMxApplication ThisApplication
  {
    get { return Application as IMxApplication; }
  }
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  public static IDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IDocumentEvents_Event;
      return s_docEvent;
    }
  }
  public static IEditor Editor
  {
    get
    {
      UID editorUID = new UID();
      editorUID.Value = "esriEditor.Editor";
      return Application.FindExtensionByCLSID(editorUID) as IEditor;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}

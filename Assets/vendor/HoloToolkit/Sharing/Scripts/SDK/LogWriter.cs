//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace HoloToolkit.Sharing {

public class LogWriter : System.IDisposable {
  private System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal LogWriter(System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(LogWriter obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LogWriter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_LogWriter(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
    }
  }

  public virtual void WriteLogEntry(LogSeverity severity, string message) {
    if (SwigDerivedClassHasMethod("WriteLogEntry", swigMethodTypes0)) SharingClientPINVOKE.LogWriter_WriteLogEntrySwigExplicitLogWriter(swigCPtr, (int)severity, message); else SharingClientPINVOKE.LogWriter_WriteLogEntry(swigCPtr, (int)severity, message);
    if (SharingClientPINVOKE.SWIGPendingException.Pending) throw SharingClientPINVOKE.SWIGPendingException.Retrieve();
  }

  public LogWriter() : this(SharingClientPINVOKE.new_LogWriter(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("WriteLogEntry", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateLogWriter_0(SwigDirectorWriteLogEntry);
    SharingClientPINVOKE.LogWriter_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, System.Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(LogWriter));
    return hasDerivedMethod;
  }

  private void SwigDirectorWriteLogEntry(int severity, string message) {
    WriteLogEntry((LogSeverity)severity, message);
  }

  public delegate void SwigDelegateLogWriter_0(int severity, string message);

  private SwigDelegateLogWriter_0 swigDelegate0;

  private static System.Type[] swigMethodTypes0 = new System.Type[] { typeof(LogSeverity), typeof(string) };
}

}

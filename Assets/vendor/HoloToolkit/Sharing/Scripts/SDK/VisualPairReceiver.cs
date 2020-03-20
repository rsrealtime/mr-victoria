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

public class VisualPairReceiver : PairMaker {
  private System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VisualPairReceiver(System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.VisualPairReceiver_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(VisualPairReceiver obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VisualPairReceiver() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_VisualPairReceiver(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static VisualPairReceiver Create() {
    System.IntPtr cPtr = SharingClientPINVOKE.VisualPairReceiver_Create();
    VisualPairReceiver ret = (cPtr == System.IntPtr.Zero) ? null : new VisualPairReceiver(cPtr, true);
    return ret; 
  }

  public virtual TagImage CreateTagImage() {
    System.IntPtr cPtr = SharingClientPINVOKE.VisualPairReceiver_CreateTagImage(swigCPtr);
    TagImage ret = (cPtr == System.IntPtr.Zero) ? null : new TagImage(cPtr, true);
    return ret; 
  }

}

}

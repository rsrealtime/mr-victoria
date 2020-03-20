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

public class IntElement : Element {
  private System.Runtime.InteropServices.HandleRef swigCPtr;

  internal IntElement(System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.IntElement_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static System.Runtime.InteropServices.HandleRef getCPtr(IntElement obj) {
    return (obj == null) ? new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IntElement() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_IntElement(swigCPtr);
        }
        swigCPtr = new System.Runtime.InteropServices.HandleRef(null, System.IntPtr.Zero);
      }
      System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static IntElement Cast(Element element) {
    System.IntPtr cPtr = SharingClientPINVOKE.IntElement_Cast(Element.getCPtr(element));
    IntElement ret = (cPtr == System.IntPtr.Zero) ? null : new IntElement(cPtr, true);
    return ret; 
  }

  public virtual int GetValue() {
    int ret = SharingClientPINVOKE.IntElement_GetValue(swigCPtr);
    return ret;
  }

  public virtual void SetValue(int newValue) {
    SharingClientPINVOKE.IntElement_SetValue(swigCPtr, newValue);
  }

}

}
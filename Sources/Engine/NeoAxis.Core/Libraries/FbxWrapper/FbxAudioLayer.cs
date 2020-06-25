//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Fbx {

public class FbxAudioLayer : FbxCollection {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxAudioLayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxAudioLayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAudioLayer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      FbxWrapperNativePINVOKE.FbxAudioLayer_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxAudioLayer_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxAudioLayer_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxAudioLayer Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxAudioLayer_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxAudioLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAudioLayer(cPtr, false);
    return ret;
  }

  public new static FbxAudioLayer Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxAudioLayer_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxAudioLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAudioLayer(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t Mute {
    set {
      FbxWrapperNativePINVOKE.FbxAudioLayer_Mute_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxAudioLayer_Mute_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t Solo {
    set {
      FbxWrapperNativePINVOKE.FbxAudioLayer_Solo_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxAudioLayer_Solo_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble Volume {
    set {
      FbxWrapperNativePINVOKE.FbxAudioLayer_Volume_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxAudioLayer_Volume_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t Lock {
    set {
      FbxWrapperNativePINVOKE.FbxAudioLayer_Lock_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxAudioLayer_Lock_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 Color {
    set {
      FbxWrapperNativePINVOKE.FbxAudioLayer_Color_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxAudioLayer_Color_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public void Reset() {
    FbxWrapperNativePINVOKE.FbxAudioLayer_Reset(swigCPtr);
  }

}

}
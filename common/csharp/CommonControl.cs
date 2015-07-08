/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.thialgou.commonWRAP {

using System;
using System.Runtime.InteropServices;

public class CommonControl : CommonElt {
  private HandleRef swigCPtr;

  internal CommonControl(IntPtr cPtr, bool cMemoryOwn) : base(commonWRAPPINVOKE.CommonControl_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CommonControl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CommonControl() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          commonWRAPPINVOKE.delete_CommonControl(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CommonControl(string strName, string strExpression, double dValue) : this(commonWRAPPINVOKE.new_CommonControl(strName, strExpression, dValue), true) {
    if (commonWRAPPINVOKE.SWIGPendingException.Pending) throw commonWRAPPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string getName() {
    string ret = commonWRAPPINVOKE.CommonControl_getName(swigCPtr);
    return ret;
  }

  public virtual string getExpression() {
    string ret = commonWRAPPINVOKE.CommonControl_getExpression(swigCPtr);
    return ret;
  }

  public virtual double getValue() {
    double ret = commonWRAPPINVOKE.CommonControl_getValue(swigCPtr);
    return ret;
  }

}

}
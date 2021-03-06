using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
///<summary>
///Represents the MFN_M05_MF_LOC_DEPT Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: LDP (LDP - location department segment) </li>
///<li>1: LCH (LCH - location characteristic segment) optional repeating</li>
///<li>2: LCC (LCC - location charge code segment) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class MFN_M05_MF_LOC_DEPT : AbstractGroup {

	///<summary> 
	/// Creates a new MFN_M05_MF_LOC_DEPT Group.
	///</summary>
	public MFN_M05_MF_LOC_DEPT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(LDP), true, false);
	      this.add(typeof(LCH), false, true);
	      this.add(typeof(LCC), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M05_MF_LOC_DEPT - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns LDP (LDP - location department segment) - creates it if necessary
	///</summary>
	public LDP LDP { 
get{
	   LDP ret = null;
	   try {
	      ret = (LDP)this.GetStructure("LDP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of LCH (LCH - location characteristic segment) - creates it if necessary
	///</summary>
	public LCH GetLCH() {
	   LCH ret = null;
	   try {
	      ret = (LCH)this.GetStructure("LCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LCH
	/// * (LCH - location characteristic segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LCH GetLCH(int rep) { 
	   return (LCH)this.GetStructure("LCH", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCH 
	 */ 
	public int LCHRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCH").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the LCH results 
	 */ 
	public IEnumerable<LCH> LCHs 
	{ 
		get
		{
			for (int rep = 0; rep < LCHRepetitionsUsed; rep++)
			{
				yield return (LCH)this.GetStructure("LCH", rep);
			}
		}
	}

	///<summary>
	///Adds a new LCH
	///</summary>
	public LCH AddLCH()
	{
		return this.AddStructure("LCH") as LCH;
	}

	///<summary>
	///Removes the given LCH
	///</summary>
	public void RemoveLCH(LCH toRemove)
	{
		this.RemoveStructure("LCH", toRemove);
	}

	///<summary>
	///Removes the LCH at the given index
	///</summary>
	public void RemoveLCHAt(int index)
	{
		this.RemoveRepetition("LCH", index);
	}

	///<summary>
	/// Returns  first repetition of LCC (LCC - location charge code segment) - creates it if necessary
	///</summary>
	public LCC GetLCC() {
	   LCC ret = null;
	   try {
	      ret = (LCC)this.GetStructure("LCC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LCC
	/// * (LCC - location charge code segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LCC GetLCC(int rep) { 
	   return (LCC)this.GetStructure("LCC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCC 
	 */ 
	public int LCCRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCC").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the LCC results 
	 */ 
	public IEnumerable<LCC> LCCs 
	{ 
		get
		{
			for (int rep = 0; rep < LCCRepetitionsUsed; rep++)
			{
				yield return (LCC)this.GetStructure("LCC", rep);
			}
		}
	}

	///<summary>
	///Adds a new LCC
	///</summary>
	public LCC AddLCC()
	{
		return this.AddStructure("LCC") as LCC;
	}

	///<summary>
	///Removes the given LCC
	///</summary>
	public void RemoveLCC(LCC toRemove)
	{
		this.RemoveStructure("LCC", toRemove);
	}

	///<summary>
	///Removes the LCC at the given index
	///</summary>
	public void RemoveLCCAt(int index)
	{
		this.RemoveRepetition("LCC", index);
	}

}
}

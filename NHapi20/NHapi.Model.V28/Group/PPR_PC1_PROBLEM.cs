using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V28.Segment;
using NHapi.Model.V28.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V28.Group
{
///<summary>
///Represents the PPR_PC1_PROBLEM Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: PRB (Problem Details) </li>
///<li>1: NTE (Notes and Comments) optional repeating</li>
///<li>2: VAR (Variance) optional repeating</li>
///<li>3: PPR_PC1_PROBLEM_ROLE (a Group object) optional repeating</li>
///<li>4: PPR_PC1_PATHWAY (a Group object) optional repeating</li>
///<li>5: PPR_PC1_PROBLEM_OBSERVATION (a Group object) optional repeating</li>
///<li>6: PPR_PC1_GOAL (a Group object) optional repeating</li>
///<li>7: PPR_PC1_ORDER (a Group object) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class PPR_PC1_PROBLEM : AbstractGroup {

	///<summary> 
	/// Creates a new PPR_PC1_PROBLEM Group.
	///</summary>
	public PPR_PC1_PROBLEM(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PRB), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(VAR), false, true);
	      this.add(typeof(PPR_PC1_PROBLEM_ROLE), false, true);
	      this.add(typeof(PPR_PC1_PATHWAY), false, true);
	      this.add(typeof(PPR_PC1_PROBLEM_OBSERVATION), false, true);
	      this.add(typeof(PPR_PC1_GOAL), false, true);
	      this.add(typeof(PPR_PC1_ORDER), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PPR_PC1_PROBLEM - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns PRB (Problem Details) - creates it if necessary
	///</summary>
	public PRB PRB { 
get{
	   PRB ret = null;
	   try {
	      ret = (PRB)this.GetStructure("PRB");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns  first repetition of VAR (Variance) - creates it if necessary
	///</summary>
	public VAR GetVAR() {
	   VAR ret = null;
	   try {
	      ret = (VAR)this.GetStructure("VAR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of VAR
	/// * (Variance) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public VAR GetVAR(int rep) { 
	   return (VAR)this.GetStructure("VAR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of VAR 
	 */ 
	public int VARRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("VAR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the VAR results 
	 */ 
	public IEnumerable<VAR> VARs 
	{ 
		get
		{
			for (int rep = 0; rep < VARRepetitionsUsed; rep++)
			{
				yield return (VAR)this.GetStructure("VAR", rep);
			}
		}
	}

	///<summary>
	///Adds a new VAR
	///</summary>
	public VAR AddVAR()
	{
		return this.AddStructure("VAR") as VAR;
	}

	///<summary>
	///Removes the given VAR
	///</summary>
	public void RemoveVAR(VAR toRemove)
	{
		this.RemoveStructure("VAR", toRemove);
	}

	///<summary>
	///Removes the VAR at the given index
	///</summary>
	public void RemoveVARAt(int index)
	{
		this.RemoveRepetition("VAR", index);
	}

	///<summary>
	/// Returns  first repetition of PPR_PC1_PROBLEM_ROLE (a Group object) - creates it if necessary
	///</summary>
	public PPR_PC1_PROBLEM_ROLE GetPROBLEM_ROLE() {
	   PPR_PC1_PROBLEM_ROLE ret = null;
	   try {
	      ret = (PPR_PC1_PROBLEM_ROLE)this.GetStructure("PROBLEM_ROLE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PPR_PC1_PROBLEM_ROLE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PPR_PC1_PROBLEM_ROLE GetPROBLEM_ROLE(int rep) { 
	   return (PPR_PC1_PROBLEM_ROLE)this.GetStructure("PROBLEM_ROLE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPR_PC1_PROBLEM_ROLE 
	 */ 
	public int PROBLEM_ROLERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROBLEM_ROLE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PPR_PC1_PROBLEM_ROLE results 
	 */ 
	public IEnumerable<PPR_PC1_PROBLEM_ROLE> PROBLEM_ROLEs 
	{ 
		get
		{
			for (int rep = 0; rep < PROBLEM_ROLERepetitionsUsed; rep++)
			{
				yield return (PPR_PC1_PROBLEM_ROLE)this.GetStructure("PROBLEM_ROLE", rep);
			}
		}
	}

	///<summary>
	///Adds a new PPR_PC1_PROBLEM_ROLE
	///</summary>
	public PPR_PC1_PROBLEM_ROLE AddPROBLEM_ROLE()
	{
		return this.AddStructure("PROBLEM_ROLE") as PPR_PC1_PROBLEM_ROLE;
	}

	///<summary>
	///Removes the given PPR_PC1_PROBLEM_ROLE
	///</summary>
	public void RemovePROBLEM_ROLE(PPR_PC1_PROBLEM_ROLE toRemove)
	{
		this.RemoveStructure("PROBLEM_ROLE", toRemove);
	}

	///<summary>
	///Removes the PPR_PC1_PROBLEM_ROLE at the given index
	///</summary>
	public void RemovePROBLEM_ROLEAt(int index)
	{
		this.RemoveRepetition("PROBLEM_ROLE", index);
	}

	///<summary>
	/// Returns  first repetition of PPR_PC1_PATHWAY (a Group object) - creates it if necessary
	///</summary>
	public PPR_PC1_PATHWAY GetPATHWAY() {
	   PPR_PC1_PATHWAY ret = null;
	   try {
	      ret = (PPR_PC1_PATHWAY)this.GetStructure("PATHWAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PPR_PC1_PATHWAY
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PPR_PC1_PATHWAY GetPATHWAY(int rep) { 
	   return (PPR_PC1_PATHWAY)this.GetStructure("PATHWAY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPR_PC1_PATHWAY 
	 */ 
	public int PATHWAYRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATHWAY").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PPR_PC1_PATHWAY results 
	 */ 
	public IEnumerable<PPR_PC1_PATHWAY> PATHWAYs 
	{ 
		get
		{
			for (int rep = 0; rep < PATHWAYRepetitionsUsed; rep++)
			{
				yield return (PPR_PC1_PATHWAY)this.GetStructure("PATHWAY", rep);
			}
		}
	}

	///<summary>
	///Adds a new PPR_PC1_PATHWAY
	///</summary>
	public PPR_PC1_PATHWAY AddPATHWAY()
	{
		return this.AddStructure("PATHWAY") as PPR_PC1_PATHWAY;
	}

	///<summary>
	///Removes the given PPR_PC1_PATHWAY
	///</summary>
	public void RemovePATHWAY(PPR_PC1_PATHWAY toRemove)
	{
		this.RemoveStructure("PATHWAY", toRemove);
	}

	///<summary>
	///Removes the PPR_PC1_PATHWAY at the given index
	///</summary>
	public void RemovePATHWAYAt(int index)
	{
		this.RemoveRepetition("PATHWAY", index);
	}

	///<summary>
	/// Returns  first repetition of PPR_PC1_PROBLEM_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public PPR_PC1_PROBLEM_OBSERVATION GetPROBLEM_OBSERVATION() {
	   PPR_PC1_PROBLEM_OBSERVATION ret = null;
	   try {
	      ret = (PPR_PC1_PROBLEM_OBSERVATION)this.GetStructure("PROBLEM_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PPR_PC1_PROBLEM_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PPR_PC1_PROBLEM_OBSERVATION GetPROBLEM_OBSERVATION(int rep) { 
	   return (PPR_PC1_PROBLEM_OBSERVATION)this.GetStructure("PROBLEM_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPR_PC1_PROBLEM_OBSERVATION 
	 */ 
	public int PROBLEM_OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROBLEM_OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PPR_PC1_PROBLEM_OBSERVATION results 
	 */ 
	public IEnumerable<PPR_PC1_PROBLEM_OBSERVATION> PROBLEM_OBSERVATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < PROBLEM_OBSERVATIONRepetitionsUsed; rep++)
			{
				yield return (PPR_PC1_PROBLEM_OBSERVATION)this.GetStructure("PROBLEM_OBSERVATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new PPR_PC1_PROBLEM_OBSERVATION
	///</summary>
	public PPR_PC1_PROBLEM_OBSERVATION AddPROBLEM_OBSERVATION()
	{
		return this.AddStructure("PROBLEM_OBSERVATION") as PPR_PC1_PROBLEM_OBSERVATION;
	}

	///<summary>
	///Removes the given PPR_PC1_PROBLEM_OBSERVATION
	///</summary>
	public void RemovePROBLEM_OBSERVATION(PPR_PC1_PROBLEM_OBSERVATION toRemove)
	{
		this.RemoveStructure("PROBLEM_OBSERVATION", toRemove);
	}

	///<summary>
	///Removes the PPR_PC1_PROBLEM_OBSERVATION at the given index
	///</summary>
	public void RemovePROBLEM_OBSERVATIONAt(int index)
	{
		this.RemoveRepetition("PROBLEM_OBSERVATION", index);
	}

	///<summary>
	/// Returns  first repetition of PPR_PC1_GOAL (a Group object) - creates it if necessary
	///</summary>
	public PPR_PC1_GOAL GetGOAL() {
	   PPR_PC1_GOAL ret = null;
	   try {
	      ret = (PPR_PC1_GOAL)this.GetStructure("GOAL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PPR_PC1_GOAL
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PPR_PC1_GOAL GetGOAL(int rep) { 
	   return (PPR_PC1_GOAL)this.GetStructure("GOAL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPR_PC1_GOAL 
	 */ 
	public int GOALRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GOAL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PPR_PC1_GOAL results 
	 */ 
	public IEnumerable<PPR_PC1_GOAL> GOALs 
	{ 
		get
		{
			for (int rep = 0; rep < GOALRepetitionsUsed; rep++)
			{
				yield return (PPR_PC1_GOAL)this.GetStructure("GOAL", rep);
			}
		}
	}

	///<summary>
	///Adds a new PPR_PC1_GOAL
	///</summary>
	public PPR_PC1_GOAL AddGOAL()
	{
		return this.AddStructure("GOAL") as PPR_PC1_GOAL;
	}

	///<summary>
	///Removes the given PPR_PC1_GOAL
	///</summary>
	public void RemoveGOAL(PPR_PC1_GOAL toRemove)
	{
		this.RemoveStructure("GOAL", toRemove);
	}

	///<summary>
	///Removes the PPR_PC1_GOAL at the given index
	///</summary>
	public void RemoveGOALAt(int index)
	{
		this.RemoveRepetition("GOAL", index);
	}

	///<summary>
	/// Returns  first repetition of PPR_PC1_ORDER (a Group object) - creates it if necessary
	///</summary>
	public PPR_PC1_ORDER GetORDER() {
	   PPR_PC1_ORDER ret = null;
	   try {
	      ret = (PPR_PC1_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PPR_PC1_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PPR_PC1_ORDER GetORDER(int rep) { 
	   return (PPR_PC1_ORDER)this.GetStructure("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPR_PC1_ORDER 
	 */ 
	public int ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PPR_PC1_ORDER results 
	 */ 
	public IEnumerable<PPR_PC1_ORDER> ORDERs 
	{ 
		get
		{
			for (int rep = 0; rep < ORDERRepetitionsUsed; rep++)
			{
				yield return (PPR_PC1_ORDER)this.GetStructure("ORDER", rep);
			}
		}
	}

	///<summary>
	///Adds a new PPR_PC1_ORDER
	///</summary>
	public PPR_PC1_ORDER AddORDER()
	{
		return this.AddStructure("ORDER") as PPR_PC1_ORDER;
	}

	///<summary>
	///Removes the given PPR_PC1_ORDER
	///</summary>
	public void RemoveORDER(PPR_PC1_ORDER toRemove)
	{
		this.RemoveStructure("ORDER", toRemove);
	}

	///<summary>
	///Removes the PPR_PC1_ORDER at the given index
	///</summary>
	public void RemoveORDERAt(int index)
	{
		this.RemoveRepetition("ORDER", index);
	}

}
}

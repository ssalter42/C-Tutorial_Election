using System;
using System.Collections.Generic;

namespace C2C.CSharpTutorial {
  
  public class ClubVote {
    
    public ClubVote(int voterId, int candidateId) {
      VoterId = voterId;
      CandidateId = candidateId;
    }
      
    public int VoterId { get; set; }
    public int CandidateId { get; set; }
  }

}
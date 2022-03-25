using System;
using System.Collections.Generic;

namespace C2C.CSharpTutorial {

  public class ClubMember {

    public ClubMember(int id, string name, int grade, string color) {
      Id = id;
      Name = name;
      Grade = grade;
      FavoriteColor = color;
    }
    
    public int Id { get; set; }
    public string Name  { get; set; }
    public int Grade  { get; set; }
    public string FavoriteColor  { get; set; }
  }
}

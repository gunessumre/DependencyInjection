using System;

namespace DependencyInjection;

public class sailorTeacher : Teacher
{
  public string Language { get; set; }
  public sailorTeacher(string firstName, string lastName, string language) : base(firstName, lastName)
  {
    Language = language;
  }

  public override string GetInfo()
  {
    return $"{base.GetInfo()} - {Language}";
  }
}
